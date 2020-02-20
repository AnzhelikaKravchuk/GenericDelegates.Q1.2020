using System;

namespace Delegates.Q1._2020
{
    public static class FunctionExtensions
    {
        /// <summary>
        ///   Tries to invoke the specified function up to 3 times if the result is unavailable 
        /// </summary>
        /// <param name="function">specified function</param>
        /// <returns>
        ///   Returns the result of specified function, if WebException occurs during request then exception should
        ///   be logged into trace 
        ///   and the new request should be started (up to 3 times).
        /// </returns>
        /// <example>
        ///   Sometimes if network is unstable it is required to try several request to get data:
        ///   
        ///   Func<string> f1 = ()=>(new System.Net.WebClient()).DownloadString("http://www.google.com/");
        ///   string data = f1.TimeoutSafeInvoke();
        ///   
        ///   If the first attempt to download data is failed by WebException then exception should be logged to trace
        ///   log and the second attempt should be started.
        ///   The second attempt has the same workflow.
        ///   If the third attempt fails then this exception should be rethrow to the application.
        /// </example>
        public static T TimeoutSafeInvoke<T>(this Func<T> function)
        {
            // TODO : Implement TimeoutSafeInvoke<T>
            throw new NotImplementedException();
        }

        /// <summary>
        ///   Combines several predicates using logical AND operator 
        /// </summary>
        /// <param name="predicates">array of predicates</param>
        /// <returns>
        ///   Returns a new predicate that combine the specified predicated using AND operator
        /// </returns>
        /// <example>
        ///   var result = CombinePredicatesWithAnd(new Predicate<string>[] {
        ///            x => !string.IsNullOrEmpty(x),
        ///            x => x.StartsWith("START"),
        ///            x => x.EndsWith("END"),
        ///            x => x.Contains("#")
        ///        });
        ///   should return the predicate that identical to 
        ///   x=> (!string.IsNullOrEmpty(x)) && x.StartsWith("START") && x.EndsWith("END") && x.Contains("#")
        ///
        ///   The following example should create predicate that returns true if int value between -10 and 10:
        ///   var result = CombinePredicatesWithAnd(new Predicate<int>[] {
        ///            x => x > -10,
        ///            x => x < 10
        ///       });
        /// </example>
        public static Predicate<T> CombinePredicatesWithAnd<T>(Predicate<T>[] predicates)
        {
            // TODO : Implement CombinePredicatesWithAnd<T>
            throw new NotImplementedException();
        }
    }
}