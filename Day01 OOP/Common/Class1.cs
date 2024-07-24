namespace Common
{
    public class TypeA
    {
        int x;
        internal int y;
        public int z;
    }
    #region UserDefinedType Video2
    //public interface ICar
    //{
    //    void Accelrate();
    //}
    //public class BMCar : ICar
    //{
    //    public void Accelrate()
    //    { }
    //}
    //public enum Gender
    //{
    //    male,
    //    female
    //} 
    #endregion



    #region AccessModifiers Video3
    public class Employee
    {
        protected int id;
        protected string? name;
    }
    public class FullTimeEmployee : Employee
    {

        public decimal Salary;
    }

    public class PartTimeEmployee : Employee
    {

        public decimal hourRate;
    }

    #endregion

}