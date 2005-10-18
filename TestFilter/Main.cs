/*

NeatUpload - an HttpModule and User Controls for uploading large files
Copyright (C) 2005  Dean Brettle

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/
using System;

#if USE_LOG4NET
[assembly: log4net.Config.XmlConfigurator(ConfigFile="log4net.config", Watch=true)]
#else
#warning LOGGING DISABLED.  To enable logging, add a reference to log4net and define USE_LOG4NET.
#endif

class MainClass
{
	public static int Main(string[] args)
	{
		return Brettle.Web.NeatUpload.FilterTester.Main(args);
	}
}