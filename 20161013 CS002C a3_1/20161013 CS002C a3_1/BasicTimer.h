// NAME:  BasicTimer
// DESC:  Description for the BasicTimer object used to create and manage 
//        timer objects.
// AUTH:  Anthony Anadon (C) 2016

#include <time.h>
#include <cstdlib>

#pragma once

class cBasicTimer{
private:
  static bool timerEnabled;
  static clock_t stopTime;
  static clock_t startTime;
 
public:
  static void StopTimer();
  static void StartTimer();

  static double GetElapsedTime();
};
