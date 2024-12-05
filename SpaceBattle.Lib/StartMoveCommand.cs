namespace SpaceBattle.Lib;
public class StartMoveCommand(ICommand _macrocommand, ISender _isender, IDictionary<string, object> _gameobject) : ICommand
{
    public void Execute()
    {
        _gameobject["Movement"] = _macrocommand;
        _isender.Send(_macrocommand);
    }

}