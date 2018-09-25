﻿using System;

namespace Task1
{
    
    public abstract class Unit
    {
        protected int xPos;
        protected int yPos;
        protected int hP;
        protected int maxHP;
        protected int speed;
        protected int attack;
        protected int atkRange;
        protected string team;
        protected string symbol;
        protected string name;

        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Team { get => team; set => team = value; }
        public int HP { get => hP; set => hP = value; }

        public Unit(int xPos, int yPos, int maxHP, int HP, int speed, int attack, int atkRange, string team, string symbol, string name)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.maxHP = maxHP;
            this.HP = HP;
            this.speed = speed;
            this.attack = attack;
            this.atkRange = atkRange;
            this.team = team;
            this.symbol = symbol;
            this.name = name;
        }

        public abstract void Attack();
        public abstract bool inRange(int enemyX, int enemyY);
        public abstract bool isDead();
        public abstract string ToString();

        public abstract void SaveUnit();

        public void updatePos(string direction) //changes the x or y value based on movement
        {
            switch (direction)
            {
                case "w":
                    {
                        yPos = yPos - 1;
                    }
                    break;
                case "a":
                    {
                        xPos = xPos - 1;
                    }
                    break;
                case "s":
                    {
                        yPos = yPos + 1;
                    }
                    break;
                case "d":
                    {
                        xPos = xPos + 1;
                    }
                    break;
            }
        }

        public Unit closestUnit(Unit[] unit)
        {
            Unit temp = null;
            int closest = 0;
            int x = xPos;
            int y = yPos;
            for (int i = 0; i < unit.Length; i++)
            {
                if (unit[i].team != team)
                {
                    x = Math.Abs(this.XPos - unit[i].XPos);
                    y = Math.Abs(this.YPos - unit[i].YPos);

                    if (closest < (x + y))
                    {
                        closest = x + y;
                        temp = unit[i];
                    }
                }        
            }
            return temp;
        }

    }
}
