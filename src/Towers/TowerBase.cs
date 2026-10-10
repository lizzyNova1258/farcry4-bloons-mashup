namespace FarCry4BloonsMashup.Towers;

public class TowerBase
{
    public string Id { get; set; } = "dart_monkey";
    public string Name { get; set; } = "Dart Monkey";
    public int Cost { get; set; } = 120;
    public float Damage { get; set; } = 9f;
    public float Range { get; set; } = 22f;
    public float FireRate { get; set; } = 1.2f;
    public int Level { get; set; } = 1;

    public virtual void Fire()
    {
        // Prototype fire behavior; the real host game will wire in actual projectile logic.
    }
}

public class DartMonkey : TowerBase
{
    public DartMonkey()
    {
        Id = "dart_monkey";
        Name = "Dart Monkey";
        Cost = 120;
        Damage = 9f;
        Range = 22f;
        FireRate = 1.2f;
    }
}

public class TackShooter : TowerBase
{
    public TackShooter()
    {
        Id = "tack_shooter";
        Name = "Tack Shooter";
        Cost = 170;
        Damage = 6f;
        Range = 18f;
        FireRate = 0.8f;
    }
}

public class SniperMonkey : TowerBase
{
    public SniperMonkey()
    {
        Id = "sniper_monkey";
        Name = "Sniper Monkey";
        Cost = 220;
        Damage = 25f;
        Range = 36f;
        FireRate = 0.9f;
    }
}

public class BombShooter : TowerBase
{
    public BombShooter()
    {
        Id = "bomb_shooter";
        Name = "Bomb Shooter";
        Cost = 260;
        Damage = 18f;
        Range = 20f;
        FireRate = 1.0f;
    }
}
