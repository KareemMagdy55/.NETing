using System.Diagnostics;

namespace Playground;

public class Playground {
   public static void Main() {
      StackTrace st = new StackTrace();
      StackFrame[] stackFrames = st.GetFrames();
      
      for(int i = 0 ; i < stackFrames.Length ; i ++)
         Console.WriteLine(stackFrames[i].GetMethod());
   }
}