using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// A Delegate holds the reference of a method the calls to execute the method,

// A Multicast Delegate is Delagate that have reference of more than one methods.

// Suppose in a class if we are having multiple method with same signature we can all those method by using same delegate.

// Note: all the methods in a class should have same signature that is return type and parameter type should match with each other to implement Multicast delegate.
// Note: suppose we have multiple method in a class and that has to be executed with same (parameter) value in that case we can just bind all the method to one delegate and then call delegate. it will execute all the method at once.

// suppose if the methods are value returning and if we implement Multicast delegate only value of last method will return as because other value will be overriden by each other.
// It is better to use non-value returning methods in multicast delegate.

namespace Delegates
{
     class MultiCastDelegate
    {
    }
}
