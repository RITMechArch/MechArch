//Units in Inhces

PlateX = 5;
PlateY = 8.25;
PlateThickness = 1/2;

CastorWidth = 2.375;
CastorLength = 3.625;
CastorXoffset = 1/2;
CastorYoffset = 1/2;
CastorholeR = 3/16;

WheelmountWidth = 1.061;
WheelmountLength = 1.5;
WheelmountXoffset = 1;
WheelmountYoffset = 1.75;
WheelmountAngle = -(90-76);
MountholeR = 0.07;    //#6-32 clearance hole;  Will be countersunk

MotormountWidth = 3.25;
MotormountLength = 2.125;
MotormountYoffset = 4;

$fn =50;

square([PlateX,PlateY]);

//Castor mounting holes
translate([CastorXoffset,CastorYoffset]) circle(r=CastorholeR);
translate([CastorXoffset,CastorYoffset+CastorLength]) circle(r=CastorholeR);
translate([CastorXoffset+CastorWidth,CastorYoffset]) circle(r=CastorholeR);
translate([CastorXoffset+CastorWidth,CastorYoffset+CastorLength]) circle(r=CastorholeR);


translate([WheelmountXoffset,WheelmountYoffset]) rotate(WheelmountAngle)
{
    //Wheel mounting holes
    circle(r=MountholeR);
    translate([WheelmountWidth,0]) circle(r=MountholeR);
    translate([0,WheelmountLength]) circle(r=MountholeR);
    translate([WheelmountWidth,WheelmountLength]) circle(r=MountholeR);

    //Motor mounting holes
    translate([0,MotormountYoffset])
    {
        translate([WheelmountWidth/2-MotormountWidth/2,0]) circle(r=MountholeR);
        translate([WheelmountWidth/2+MotormountWidth/2,0]) circle(r=MountholeR);
        translate([WheelmountWidth/2-MotormountWidth/2,MotormountLength]) circle(r=MountholeR);
        translate([WheelmountWidth/2+MotormountWidth/2,MotormountLength]) circle(r=MountholeR);
    }
}
