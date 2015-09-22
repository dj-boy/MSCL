/*****************************************************************************
Copyright(c) 2015 LORD Corporation. All rights reserved.

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the included
LICENSE.txt file for a copy of the full GNU General Public License.
*****************************************************************************/
#pragma once

#include "mscl/Exceptions.h"

namespace mscl
{
	//Title: NativeSerialPort_linux

	//Function: getNativeSerialPort
	//	Just returns the string passed in (no special case needed for Linux, but necessary for Windows)
	//
	//Parameters:
	//	portName - the name of the port to be opened ("COM26")
	//
	//Returns:
	//	The port name string passed in
	std::string getNativeSerialPort(std::string portName)
	{
		return portName;
	}
}