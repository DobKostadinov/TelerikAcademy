﻿namespace _01.Cooking.Models
{
    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsRotten = false;
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsCooked = false;
        }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }

        public override string ToString()
        {
            string name = this.GetType().Name;
            string peeled = this.IsPeeled ? "peeled" : "not peeled";
            string cut = this.IsCut ? "cut" : "not cut";

            string result = string.Format("{0}/{1}/{2}", name, peeled, cut);

            return result;
        }
    }
}
