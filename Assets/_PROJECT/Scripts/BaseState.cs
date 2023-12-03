public class BaseState
{
    #region VARIABLES
    public string name;
    protected StateMachine stateMachine;
    #endregion

    #region CONSTRUCTOR
    public BaseState(string name, StateMachine stateMachine)
    {
        this.name = name;
        this.stateMachine = stateMachine;
    }
    #endregion

    #region STATE METHODS
    public virtual void Enter() { } //Load Scene 
    public virtual void UpdateLogic() { }
    public virtual void AddOrRemoveListeners() { }
    public virtual void Exit() { } // Remove Scene
    #endregion
}
