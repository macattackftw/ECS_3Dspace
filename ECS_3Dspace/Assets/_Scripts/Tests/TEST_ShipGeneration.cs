﻿using Unity.Entities;
using Unity.Mathematics;

namespace Ships
{

    public static class TEST_ShipGeneration
    {
        static Entity ship;
        public static void TEST_GenerateIdleShips(ref EntityManager em)
        {
            // Create 1000 hardcoded ships for testing
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 50; ++j)
                {
                    if (i % 2 == 0)
                    {
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f + 5f, i * 15f, -20f), Faction.green, Common.zero);
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f + 5f, i * 15f, 20f), Faction.red, Common.zero);
                    }
                    else
                    {
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f, i * 15f, -25f), Faction.green, Common.zero);
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f, i * 15f, 25f), Faction.red, Common.zero);
                    }
                }
            }
        }

        public static void TEST_GenerateMovingShips(ref EntityManager em)
        {
            float3 velocity = new float3(0f, 0f, 20f);
            // Create 1000 hardcoded ships for testing
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 50; ++j)
                {
                    if (i % 2 == 0)
                    {
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f + 5f, i * 15f, -20f), Faction.green, velocity);
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f + 5f, i * 15f, 20f), Faction.red, velocity);
                    }
                    else
                    {
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f, i * 15f, -25f), Faction.green, velocity);
                        SubShip.GenerateShip(ref ship, ref em, new float3(j * 15f, i * 15f, 25f), Faction.red, velocity);
                    }
                }
            }
        }
    }
}