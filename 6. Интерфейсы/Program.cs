

class Program
{
    static void Main ()
    {
        // sealed - запечатанный, прерывает цыпочку наследования или не дает переопределить производному классу метод с модификатором sealed

        BaseShip bs = new BaseShip();
        bs.Attack();

        bs = new FightShip();
        bs.Attack();

        TransportShip ts = new TransportShip();
        ts.Attack();

    }
}
class BaseShip
{
    public virtual void Attack()
    {
        Console.WriteLine("BaseShip аттаковал");
    }
}
class FightShip : BaseShip
{
    public sealed override void Attack()
    {
        Console.WriteLine("FightShip аттаковал");
    }
}
class TransportShip : FightShip
{
    public override void Attack()
    {
        Console.WriteLine("FightShip аттаковал");
    }
}
