namespace Vectorio.Stats
{
    public enum StatType : ushort
    {
        // BASE ENTITY STATS
        Unassigned = 0,

        // BASE ENTITY STATS
        BuildingHealth = 1,

        // TURRET RELATED STATS
        TurretHealth = 2,
        TurretDamage = 3,
        TurretSpread = 4,
        TurretCooldown = 5,
        TurretRange = 6,
        BarrelSpeed = 7,

        // PROJECTILE RELATED STATS
        ProjectileSpeed = 8,
        ProjectileLifetime = 9,
        ProjectileAmount = 10,
        ProjectilePierces = 11,
        ProjectileSize = 12,
        ProjectileSplits = 13,

        // UNIT RELATED STATS
        UnitHealth = 14,
        UnitDamage = 15,
        UnitSpeed = 16,
        UnitRange = 17,
        UnitMass = 18,
        UnitSpawnRate = 19,

        // STORAGE RELATED STATS
        StorageCapacity = 20,

        // COLLECTOR RELATED STATS
        CollectorSpeed = 21,
        CollectorValue = 22,
        CollectorCapacity = 23,

        // CRAFTING RELATED STATS
        CraftingSpeed = 24,
        CraftingCapacity = 25,

        // LAB RELATED STATS
        LabSpeed = 26,
        LabValue = 27,
        LabCapacity = 28,

        // GENERATOR RELATED STATS
        GeneratorSpeed = 29,
        GeneratorCapacity = 30,

        // DRONE RELATED STATS
        DroneSpeed = 31,
        DroneCapacity = 32,
        DroneDoorSpeed = 33,
        DroneMaxActions = 34,

        // AMMO BIN STATS
        AmmoBinCapacity = 35,

        // BOOSTER STATS
        BoosterEffect = 36,
        BoosterRange = 37,

        // DECRYPTOR STATS
        DecryptorRange = 38,
        DecryptorSpawnRate = 39,

        // HIVE STATS
        HiveRange = 40,
        HiveThreshold = 41,

        // RECLAIMER STATS
        ReclaimerRange = 42,

        // SHIELDER STATS
        ShielderRange = 43,
        ShielderBurnTime = 44,

        // HUB STATS
        HubPower = 45,

        // ILLUMINATOR STATS
        LightRadius = 46,
        LightAngle = 47,
        LightOpacity = 48,

        // RADAR STATS
        RadarRange = 49,

        // WALL STATS
        WallHealth = 50
    }
}
