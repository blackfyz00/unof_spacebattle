namespace SpaceBattle.Lib;
public class Rotate : ICommand
{
    IRotatingObject RotatingObject;
    public Rotate(IRotatingObject _RotatingObject)
    {
        RotatingObject = _RotatingObject;
    }
    public void Execute()
    {
        RotatingObject.angle += RotatingObject.Velocity;
    }
}