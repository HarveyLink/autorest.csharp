// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Base type for functions that can modify document scores during ranking. </summary>
    public partial class ScoringFunction
    {
        /// <summary> Initializes a new instance of ScoringFunction. </summary>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldName"/> is null. </exception>
        public ScoringFunction(string fieldName, double boost)
        {
            if (fieldName == null)
            {
                throw new ArgumentNullException(nameof(fieldName));
            }

            FieldName = fieldName;
            Boost = boost;
        }

        /// <summary> Initializes a new instance of ScoringFunction. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to &quot;Linear&quot;. </param>
        internal ScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation)
        {
            Type = type;
            FieldName = fieldName;
            Boost = boost;
            Interpolation = interpolation;
        }

        /// <summary> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </summary>
        internal string Type { get; set; }
        /// <summary> The name of the field used as input to the scoring function. </summary>
        public string FieldName { get; set; }
        /// <summary> A multiplier for the raw score. Must be a positive number not equal to 1.0. </summary>
        public double Boost { get; set; }
        /// <summary> A value indicating how boosting will be interpolated across document scores; defaults to &quot;Linear&quot;. </summary>
        public ScoringFunctionInterpolation? Interpolation { get; set; }
    }
}
