﻿// See https://aka.ms/new-console-template for more information

using System;
using CAFacebook;

var comments = new List<FBComment>
            {
                new FBComment
                {
                    Owner = "Issam A.",
                    Comment = "I Think ASP NET Core is the most powerfull Web Framework",
                    CreatedAt = new DateTime (2021, 01, 01, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Reem S.",
                    Comment = "Personally I Prefere Using C# with it.",
                    CreatedAt = new DateTime(2021, 02, 01, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Issam A.",
                    Comment = "Have you Tried Using Blazor?",
                    CreatedAt = new DateTime(2021, 06, 01, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Reem S.",
                    Comment = "Have you Tried Using Blazor?",
                    CreatedAt = new DateTime(2021, 06, 28, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Abeer B.",
                    Comment = "I Prefer VB over C#.",
                    CreatedAt = new DateTime(2021, 07, 11, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Abeer B.",
                    Comment = "VB is not from C family languages, It's hard for me",
                    CreatedAt = DateTime.Now.AddMinutes(-5)
                }
            };



















