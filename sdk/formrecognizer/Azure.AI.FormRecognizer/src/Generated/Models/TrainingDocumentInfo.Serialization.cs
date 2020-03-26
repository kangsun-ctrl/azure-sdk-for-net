// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Custom
{
    public partial class TrainingDocumentInfo
    {
        internal static TrainingDocumentInfo DeserializeTrainingDocumentInfo(JsonElement element)
        {
            string documentName = default;
            int pages = default;
            IReadOnlyList<FormRecognizerError> errors = new List<FormRecognizerError>();
            TrainingStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentName"))
                {
                    documentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"))
                {
                    pages = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToTrainingStatus();
                    continue;
                }
            }
            return new TrainingDocumentInfo(documentName, pages, errors, status);
        }
    }
}
