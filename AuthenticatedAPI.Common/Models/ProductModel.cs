﻿namespace AuthenticatedAPI.Common.Models;

public class ProductModel
{
    public int Id{get; set;}
    public decimal Price {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public CategoryModel category {get; set;}

}
