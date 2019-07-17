﻿//<Snippet1>
using System;

namespace DesignLibrary
{
   class History
   {
      internal void AddToHistory(string uriString) {}
      internal void AddToHistory(Uri uriType) {}
   }

   public class Browser
   {
      History uriHistory = new History();

      public void ErrorProne()
      {
         uriHistory.AddToHistory("http://www.adventure-works.com");
      }

      public void SaferWay()
      {
         try
         {
            Uri newUri = new Uri("http://www.adventure-works.com");
            uriHistory.AddToHistory(newUri);
         }
         catch(UriFormatException uriException) {}
      }
   }
}
//</Snippet1>
