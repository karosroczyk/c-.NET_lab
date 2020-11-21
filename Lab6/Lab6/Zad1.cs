using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab6
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
        Orange,
    }
    public enum Type
    {
        Angle,
        Star,
        Sphere,
    }
    class Tree
    {
        string name;
        int age;

        public Tree(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Fir : Tree
    {
        protected List<Bauble> baubleList = new List<Bauble>();
        public Fir(string name, int age) : base(name, age){}
        public void AddBauble(Color baubleColor, Type baubleType)
        {
            baubleList.Add(new Bauble(baubleColor, baubleType));
        }
        public void RemoveBauble(int index)
        {
            baubleList.RemoveAt(index);
        }
        protected  class Bauble
        {
            public Color baubleColor { get; set; }
            public Type baubleType { get; set; }
            public Bauble(Color baubleColor, Type baubleType)
            {
                this.baubleColor = baubleColor;
                this.baubleType = baubleType;
            }
        }
    }
    class ChristmasTree : Fir
    {
        public ChristmasTree(string name, int age) : base(name, age) { }
        public virtual Object this[int index]
        {
            get { return baubleList[index].baubleColor; }
        }
        public int this[Color baubleColor]
        {
            get { return baubleList.Where(elem => elem.baubleColor == baubleColor).Count(); }
        }
        public Color this[int index, int a]
        {
            set => baubleList[index].baubleColor = value;
        }
    }
    class ChristmasTreeA : ChristmasTree
    {
        public ChristmasTreeA(string name, int age) : base(name, age) { }
        public override Object this[int index]
        {
            get { return base.baubleList[index].baubleType; }
        }
        public Object BaubleColor(int index)
        {
            return base[index];
        }

    }
    class ChristmasTreeB : ChristmasTreeA
    {
        public ChristmasTreeB(string name, int age) : base(name, age) { }
        public Object this[int index]
        {
            get { return Tuple.Create(base[index], BaubleColor(index)); }
        }

    }
    sealed class ChristmasTreeC : ChristmasTreeA
    {
        public ChristmasTreeC(string name, int age) : base(name, age) { }
    }
    abstract class Home
    {
        protected abstract int Price();
    }
}
