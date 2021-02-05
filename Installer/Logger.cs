namespace CSharpTutorial
{
    public interface ILogger 
    {

        void LogError(string message);

        void LogInfo(string message);
    }

    /*
     So this appears to be the base class. We are going to 
    instantiate it in the controller of the "child classes"
    so as to use the Log function.
    We can implement the Name function in different ways in both classes.
    This will be polymorphism
    */

}
