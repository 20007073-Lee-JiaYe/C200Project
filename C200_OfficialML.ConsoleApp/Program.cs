// This file was auto-generated by ML.NET Model Builder. 

using System;
using C200_OfficialML.Model;

namespace C200_OfficialML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Comments = @"Drug Runners and  a U.S. Senator have something to do with the Murder http://www.amazon.com/Circumstantial-Evidence-Getting-Florida-Bozarth-ebook/dp/B004FPZ452/ref=pd_rhf_p_t_1 The State Attorney Knows... NOW So Will You. GET Ypur Copy TODAY",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
            Console.WriteLine($"Comments: {sampleData.Comments}");
            Console.WriteLine($"\n\nPredicted Label value {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
