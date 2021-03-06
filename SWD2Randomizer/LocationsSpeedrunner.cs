﻿using System.Collections.Generic;

namespace SWD2Randomizer
{
    public class LocationsSpeedrunner
    {
        public List<Location> Locations { get; set; }
        public LocationsSpeedrunner()
        {
            Locations = new List<Location>
            {
                new Location
                {
                    Name = "break_rocks",
                    Grant = "break_rocks",
                    CanAccess = have => have.Contains("jackhammer") || have.Contains("pressurebomb") || have.Contains("fate.explosions")
                },
                new Location
                {
                    Name = "fate.explosions",
                    Grant = "fate.explosions",
                    Type = Location.RandomizeType.Upgrade
                },
                new Location
                {
                    Name = "top_yarrow",
                    Grant = "top_yarrow",
                },
                new Location
                {
                    Name = "fate.xpx2",
                    Grant = "fate.xpx2",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("top_yarrow")
                },
                new Location
                {
                    Name = "main_yarrow",
                    Grant = "main_yarrow",
                    CanAccess = have => have.Contains("top_yarrow")
                },
                new Location
                {
                    Name = "yarrow_barrier_1",
                    Grant = "yarrow_barrier_1",
                    CanAccess = have => have.Contains("main_yarrow") && have.Contains("pressurebomb")
                },
                new Location
                {
                    Name = "yarrow_barrier_2",
                    Grant = "yarrow_barrier_2",
                    CanAccess = have => have.Contains("yarrow_barrier_1") && (have.Contains("pressurebomb") || (have.Contains("steampack") && have.Contains("steampack.slayer")))
                },
                new Location
                {
                    Name = "archaea_barrier",
                    Grant = "archaea_barrier",
                    CanAccess = have => have.Contains("top_yarrow") || have.Contains("pressurebomb")
                },
                new Location
                {
                    Name = "fate.bloodquest",
                    Grant = "fate.bloodquest",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("archaea_barrier") && have.Contains("break_rocks")
                },
                new Location
                {
                    Name = "oasis",
                    Grant = "oasis",
                    CanAccess = have => (have.Contains("archaea_barrier") && have.Contains("break_rocks")) || (have.Contains("main_yarrow") && ((have.Contains("steampack") && have.Contains("steampack.slayer")) || have.Contains("pressurebomb"))) || (have.Contains("middle_totd") && have.Contains("pickaxe.fire"))
                },
                new Location
                {
                    Name = "bottom_archaea",
                    Grant = "bottom_archaea",
                    CanAccess = have => have.Contains("archaea_barrier") && (have.Contains("jackhammer") || have.Contains("pressurebomb"))
                },
                new Location
                {
                    Name = "top_totd",
                    Grant = "top_totd",
                    CanAccess = have => have.Contains("hook")
                },
                new Location
                {
                    Name = "middle_totd",
                    Grant = "middle_totd",
                    CanAccess = have => (have.Contains("top_totd") && (have.Contains("jackhammer") || have.Contains("pressurebomb"))) || (have.Contains("archaea_barrier") && have.Contains("break_rocks")) || (have.Contains("oasis") && have.Contains("pressurebomb"))
                },
                new Location
                {
                    Name = "lava_pit",
                    Grant = "lava_pit",
                    CanAccess = have => have.Contains("middle_totd") && (have.Contains("hook") || have.Contains("steampack"))
                },
                new Location
                {
                    Name = "tog_generator",
                    Grant = "tog_generator",
                    CanAccess = have => have.Contains("top_yarrow") && (have.Contains("hook") || have.Contains("steampack") || (have.Contains("pressurebomb") && have.Contains("pressurebomb.launcher")))
                },
                new Location
                {
                    Name = "yarrow_generator",
                    Grant = "yarrow_generator",
                    CanAccess = have => have.Contains("yarrow_barrier_2")
                },
                new Location
                {
                    Name = "totd_generator",
                    Grant = "totd_generator",
                    CanAccess = have => have.Contains("lava_pit")
                },
                new Location
                {
                    Name = "ending",
                    Grant = "ending",
                    CanAccess = have => have.Contains("tog_generator") && have.Contains("yarrow_generator") && have.Contains("totd_generator") && have.Contains("oasis")
                },

                new Location
                {
                    Name = "pressurebomb",
                    Grant = "pressurebomb",
                    Type = Location.RandomizeType.Upgrade,
                    CanEscape = have => have.Contains("pressurebomb") || (have.Contains("steampack") && have.Contains("steampack.slayer")) || have.Contains("fate.explosions")
                },
                new Location
                {
                    Name = "pressurebomb.launcher",
                    Grant = "pressurebomb.launcher",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("top_yarrow"),
                    CanEscape = have => (have.Contains("pressurebomb") && have.Contains("pressurebomb.launcher")) || (have.Contains("steampack") && have.Contains("steampack.slayer")),
                    CanEscapeWithoutNew = have => have.Contains("pressurebomb")
                },
                new Location
                {
                    Name = "pressurebomb.launcher_triple",
                    Grant = "pressurebomb.launcher_triple",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("pressurebomb.launcher")
                },
                new Location
                {
                    Name = "jackhammer",
                    Grant = "jackhammer",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("archaea_barrier") && (have.Contains("pressurebomb") || have.Contains("jackhammer") || have.Contains("hook")),
                    CanEscape = have => have.Contains("pressurebomb") || have.Contains("jackhammer") || (have.Contains("steampack") && have.Contains("steampack.slayer"))
                },
                new Location
                {
                    Name = "hook",
                    Grant = "hook",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("oasis"),
                    CanEscape = have => have.Contains("hook") || (have.Contains("pressurebomb") && have.Contains("pressurebomb.launcher")) || have.Contains("steampack"),
                    CanEscapeWithoutNew = have => have.Contains("pressurebomb")
                },
                new Location
                {
                    Name = "steampack.slayer",
                    Grant = "steampack.slayer",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("yarrow_barrier_1") && (have.Contains("steampack") || (have.Contains("pressurebomb") && have.Contains("pressurebomb.launcher")) || have.Contains("hook")),
                    CanEscape = have => have.Contains("steampack") && have.Contains("steampack.slayer"),
                    CanEscapeWithoutNew = have => have.Contains("pressurebomb")
                },
                new Location
                {
                    Name = "pickaxe.fire",
                    Grant = "pickaxe.fire",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("middle_totd"),
                    CanEscape = have => have.Contains("pickaxe.fire")
                },
                new Location
                {
                    Name = "armor.damage_reduction",
                    Grant = "armor.damage_reduction",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("lava_pit")
                },
                new Location
                {
                    Name = "hook.long_hook",
                    Grant = "hook.long_hook",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("top_totd") && have.Contains("middle_totd") && have.Contains("pickaxe.fire")
                },
                new Location
                {
                    Name = "steampack",
                    Grant = "steampack",
                    Type = Location.RandomizeType.Upgrade,
                    CanAccess = have => have.Contains("bottom_archaea"),
                    CanEscape = have => have.Contains("steampack") || have.Contains("hook")
                },
            };
        }
    }
}
