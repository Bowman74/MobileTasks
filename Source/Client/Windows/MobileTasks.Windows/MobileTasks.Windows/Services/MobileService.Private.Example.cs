﻿using Microsoft.WindowsAzure.MobileServices;
using System;

namespace MobileTasks.Windows.Services
{
	public partial class MobileService
    {
		public MobileService()
		{
//#if DEBUG
//			this.Client = new MobileServiceClient("http://localhost:3223/")
//			{
//				AlternateLoginHost = new Uri("https://myapp.azurewebsites.net")
//			};
//#else
			this.Client = new MobileServiceClient("https://myapp.azurewebsites.net");
//#endif // DEBUG
		}
	}
}
