using System;

namespace TalentFitApp.DataLayer.Shared;

public class AppResponse<T> where T : class
{
    public string Response { get; set; }
    public int Status { get; set; }
    public AppResponse<T> Output { get; set; }
}
