using System;

namespace practiceMain {
    internal class program {
        static void Main(string[] args) {
            
        }

        class Pirson {
            protected string _name;
            protected int _age;

            public Pirson(string name, int age) {
                this._name = name;
                this._age = age;
            }

            public virtual void Id() {}
        }

        class Student : Pirson {
            public Student(string name, int age) : base(name, age) {

            }

            public override void Id() {
                Console.WriteLine("Name: " + _name);
                Console.WriteLine("age: " + _age);
            }
        }

        class Staff : Pirson {
            public Staff(string name, int age) : base(name, age) {

            }

            public override void Id() {
                Console.WriteLine("Name: " + _name);
                Console.WriteLine("age: " + _age);
            }
        }

        class Teacher : Staff {
            public Teacher(string name, int age) : base(name, age) {

            }

            public override void Id() {
                Console.WriteLine("Name: " + _name);
                Console.WriteLine("age: " + _age);
            }
        }

        class Cleaner : Staff {
            public Cleaner(string name, int age) : base(name, age) {

            }

            public override void Id() {
                Console.WriteLine("Name: " + _name);
                Console.WriteLine("age: " + _age);
            }
        }
        
    }
}