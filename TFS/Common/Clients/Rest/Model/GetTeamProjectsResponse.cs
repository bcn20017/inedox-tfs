﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Visual Studio via: 
//     Edit > Paste Special > Paste JSON as Classes
//     
//     JSON generated from: /DefaultCollection/_apis/projects
//
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inedo.Extensions.TFS.VisualStudioOnline.Model
{
    public class GetTeamProjectsResponse
    {
        public int count { get; set; }
        public GetTeamProjectResponse[] value { get; set; }
    }

    public class GetTeamProjectResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string state { get; set; }
        public int revision { get; set; }
        public string description { get; set; }
    }
}
