using System;

namespace ElectronNET.TestDemo
{
    /// <summary>
    /// This is a demo class to test trailing whitespace detection.  
    /// </summary>
    public class TrailingWhitespaceDemo
    {
        // This line has trailing spaces at the end  
        private string demoField;  

        public TrailingWhitespaceDemo()
        {
            demoField = "Hello World";  
        }

        public void DemoMethod()  
        {
            Console.WriteLine("This demonstrates the trailing whitespace check.");  
            // The workflow will detect these trailing spaces  
        }  
    }
}
