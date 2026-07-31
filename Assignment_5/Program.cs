using System.Linq.Expressions;

namespace Assignment_5;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        //(a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
        // => the new copy will only modified, the original remwin unchanged

        //(b) What happens when a Customer variable is copied into another variable and one variable modifies the object
        // => the both variables will be changed

        #endregion

        #region Question2
        //(a) Identify at least three problems with this design from an encapsulation perspective.
        // => Anyone can set invalid values
        // => public fields are open to both reading and writing and any one can change on it
        // => if we need to change fields, it will break any external code related to them

        //(b) How can private fields and public properties improve this design?
        // => Hiding Implementation Details
        // => make data read-only to the others

        #endregion
    }
}