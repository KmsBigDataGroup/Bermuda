﻿namespace Bermuda.QL
{
    //Search for {NewGetType} to add a new one
    //public enum GetTypes
    //{
    //    //Special Types
    //    SuggestedCommunication  =       -1,
    //    //Instance Types
    //    Instance                 =       0,  //00000000000000000000000000
    //        Contact              =       1,  //00000000000000000000000001
    //            Presence         =       3,  //00000000000000000000000011
    //                Organization =       7,  //00000000000000000000000111       
    //                Group        =      11,  //00000000000000000000001011
    //                Person       =      19,  //00000000000000000000010011             
    //                    User     =      51,  //00000000000000000000110011
    //            Location         =      65,  //00000000000000000001000001
    //        Activity             =     128,  //00000000000000000010000000
    //            Event            =     384,  //00000000000000000110000000
    //                Meeting      =     896,  //00000000000000001110000000
    //                Gathering    =    1408,  //00000000000000010110000000
    //            Comment          =    2176,  //00000000000000100010000000
    //            Path             =    4224,  //00000000000001000010000000
    //                File         =   12416,  //00000000000011000010000000
    //                Folder       =   20608,  //00000000000101000010000000
    //            Communication    =   32896,  //00000000001000000010000000
    //                Email        =   98432,  //00000000011000000010000000
    //                PhoneCall    =  163968,  //00000000101000000010000000
    //                Message      =  295040,  //00000001001000000010000000
    //                Tweet        =  557184,  //00000010001000000010000000
    //            SocialMention    = 1048704,  //00000100000000000010000000
    //            WorkItem         = 2097280,  //00001000000000000010000000
    //                Task         = 6291584,  //00011000000000000010000000
    //                Ticket       = 10485888, //00101000000000000010000000
    //          Tag                = 16777216  //01000000000000000000000000
    //          Setting            = 33554432  //10000000000000000000000000
    //}

    public enum GetTypes
    {
        //Special Types
        Unknown                = -999,
        Datasource             = -8,
        HandleMetric           = -7,
        SetDefinition          = -6,
        Datapoint              = -5,
        Theme                  = -4,
        Handle                 = -3,
        Keyword                = -2, 
        SuggestedCommunication = -1,
        //Instance Types
        Instance = 0,                               //000000000000000000000000000
            Contact = 1,                            //000000000000000000000000001
                Presence = 3,                       //000000000000000000000000011
                    Organization = 7,               //000000000000000000000000111       
                    Group = 11,                     //000000000000000000000001011
                    Person = 19,                    //000000000000000000000010011             
                        User = 51,                  //000000000000000000000110011
                Location = 65,                      //000000000000000000001000001
            Activity = 128,                         //000000000000000000010000000
                Event = 384,                        //000000000000000000110000000
                    Meeting = 896,                  //000000000000000001110000000
                    Gathering = 1408,               //000000000000000010110000000
                Comment = 2176,                     //000000000000000100010000000
                Path = 4224,                        //000000000000001000010000000
                    File = 12416,                   //000000000000011000010000000
                    Folder = 20608,                 //000000000000101000010000000
                Communication = 32896,              //000000000001000000010000000
                    Email = 98432,                  //000000000011000000010000000
                    PhoneCall = 163968,             //000000000101000000010000000
                    Message = 295040,               //000000001001000000010000000
                    Mention = 557184,               //000000010001000000010000000
                        SocialMention = 1605760,    //000000110001000000010000000
                        Tweet = 2654336,            //000001010001000000010000000
                WorkItem = 4194432,                 //000010000000000000010000000
                    Task = 12583040,                //000110000000000000010000000
                    Ticket = 20971648,              //001010000000000000010000000
            Tag = 33554432,                         //010000000000000000000000000
            Setting = 67108864                      //100000000000000000000000000
    }
}
