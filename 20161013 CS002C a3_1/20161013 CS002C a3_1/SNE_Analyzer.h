
#ifndef INCL_SNE_ANALYZER_H
#define INCL_SNE_ANALYZER_H

#include <cmath>
#include <string>
#include "StarNearEarth.h"

const double PI = 3.141592653589793;


using namespace std;

class SNE_Analyzer : public StarNearEarth
{
private:
   double x, y, z;

public:
   void calcCartCoords();
   double getX() { return x; }
   double getY() { return y; }
   double getZ() { return z; }
   string coordToString();
   SNE_Analyzer &operator=(const StarNearEarth &sne);
};




string SNE_Analyzer::coordToString()
{
   return "(" + to_string(x) + "," + to_string(y) + "," + to_string(z) + ")";
}



void SNE_Analyzer::calcCartCoords()
{
   double LY = 3.262 / getParallaxMean();
   double RA = getRAsc() * (PI / 180);
   double DC = getDec() * (PI / 180);

   x = LY * cos(DC) * cos(RA);
   y = LY * cos(DC) * sin(RA);
   z = LY * sin(DC);
}




SNE_Analyzer &::SNE_Analyzer::operator=(const StarNearEarth &sne)
{
   setRank(sne.getRank());
   setNameCns(sne.getNameCns());
   setNumComponents(sne.getNumComponents());
   setNameLhs(sne.getNameLhs());
   setRAsc(sne.getRAsc());
   setDec(sne.getDec());
   setPropMotionMag(sne.getPropMotionMag());
   setPropMotionDir(sne.getPropMotionDir());
   setParallaxMean(sne.getParallaxMean());
   setParallaxVariance(sne.getParallaxVariance());
   setWhiteDwarfFlag(sne.getWhiteDwarfFlag());
   setSpectralType(sne.getSpectralType());
   setMagApparent(sne.getMagApparent());
   setMagAbsolute(sne.getMagAbsolute());
   setMass(sne.getMass());
   setNotes(sne.getNotes());
   setNameCommon(sne.getNameCommon());
   calcCartCoords();

   return *this;
}
#endif
