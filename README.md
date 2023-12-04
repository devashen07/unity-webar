# Web AR Assessment 

This repo provides Unity source files for a WebAR experience.  

## Comments and Challenges

- Going about this task, I first started exploring which platforms and toolkits would be suitable to accomplish this task. I have not worked specifically within the WebAR space besides the odd tutorials I use to do a couple of years ago but realized things have really changed. After some research, I could not find a free toolkit to use that allows multiple image tracking within one session. The best option would of been to use Aframe with libraries such as AR.js. However, given my limited knowledge of these toolkits and the time constraint, I didn't feel it would properly demonstrate my technical ability and of course me having to learn a new toolkit from scratch would have been time consuming.
- As such, I eventually chose Unity. However, came to realize that the **free open source toolkits** that can be used within Unity are either not well supported or are outdated. I tried wrapping AR.js into Unity as well to no luck. I eventually settled on WebXR which has lost a lot of support within the Unity environment. 

## Methodology

### Application Architecture

The core design of the application follows a simple Finite State Machine pattern that I developed from scratch.  A FSM is a model that can be used to control execution flow. In this scenario, the FSM is made up of 2 states, that is: 
- Home
- WebAR Scene

Each state can be toggled between. Using this pattern allows separation between interfaces allowing for modular and maintainable codebase. FSMs are a nice way of decoupling behaviours to better organize the project. The states themselves have 3 important points:

| Method        | Description                                                  |
|---------------|--------------------------------------------------------------|
| Enter()       | Initialization process when transitioning to the state       |
| UpdateLogic() | Logic that runs continuously when state is current           |
| Exit()        | Any clean-ups or unsubscribe events before leaving the state | 

A second core pattern that was used is the Singleton design pattern, certain navigation events need to run through the lifetime of the application as one instance such as the navigation between states. 

The custom scripts can be found ```Assets/_PROJECT/Scripts```.

### WebXR 

I used a WebXR import within Unity to initialize a WebAR session using the WebXR manager and built-in functions within the toolkit. I faced many bottlenecks using this toolkit as it was just outdated. One major challenge was anchoring models within the real-space as the XRSession HitTests were keep failing. Furthermore, deploying effectively also had its challenges as new versions of Chrome and Samsung Internet have stop supporting certain configs of this version of WebXR and had trouble opening my camera within the browser. 

### Testing

I tested and deployed the experience using Github pages with an Android device. The resolutions are set to generic phone dimensions. The application is very buggy within AR session and sometimes would not work at all when triggered. 

## Output

- The experience is hosted using Github pages and can be found at ```https://devashen07.github.io/webar-assessment/```.
- Unity version **2019.4.39** with WebGL library installed (Had to use an older version as WebXR didnt work well on the newer LTS versions).

- Very unhappy with the end result. With the time constraint, I unfortunately cannot develop further to produce a robust solution and explore a different toolkit. 

