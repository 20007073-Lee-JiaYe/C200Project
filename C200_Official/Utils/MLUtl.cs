using C200_OfficialML.Model;
using C200_ProjectML.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class MLUtl
{
    public string PredictEmotions(string comment)
    {
        // Add input data
        var input = new ModelInput()
        {
            Comments = comment
        };

        // Load model and predict output of sample data
        ModelOutput result = ConsumeModel.Predict(input);
        return result.Prediction;

    }

    public string PredictOffensiveAngela(string comment)
    {
        // Add input data
        var input = new ModelInputAngela()
        {
            Comment_text = comment
        };

        // Load model and predict output of sample data
        ModelOutputAngela result = ConsumeModelAngela.Predict(input);
        return result.Prediction;

    }

    public string PredictCategoryNicole(string category) //what u what predict
    {
        // Add input data
        var input = new ModelInputNicole()
        {
            Category = category //run the training excel 
        };

        // Load model and predict output of sample data
        ModelOutputNicole result = ConsumeModelNicole.Predict(input);
        return result.Prediction;

    }
}

