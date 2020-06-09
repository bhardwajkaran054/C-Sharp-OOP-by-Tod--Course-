using Characters;

namespace Characters
{
    public abstract class Melee : Character
    {
        public Melee()
        {

        }

        public Melee(int healthPoints, int weight, int age)
            : base(healthPoints, weight, age)
        {

        }
    }
}
