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

MotormountWidth = 3;
MotormountLength = 1.875;
MotormountYoffset = 4;



$fn =50;

difference()
{
	cube([PlateX,PlateY,PlateThickness]);

	//Castor mounting holes
	translate([CastorXoffset,CastorYoffset,-.1]) cylinder(r=CastorholeR, h=PlateThickness+.2);
	translate([CastorXoffset,CastorYoffset+CastorLength,-.1]) cylinder(r=CastorholeR, h=PlateThickness+.2);
	translate([CastorXoffset+CastorWidth,CastorYoffset,-.1]) cylinder(r=CastorholeR, h=PlateThickness+.2);
	translate([CastorXoffset+CastorWidth,CastorYoffset+CastorLength,-.1]) cylinder(r=CastorholeR, h=PlateThickness+.2);

	
	translate([WheelmountXoffset,WheelmountYoffset,-.1]) rotate([0,0,WheelmountAngle])
	union()
	{
		//Wheel mounting holes
		cylinder(r=MountholeR, h=PlateThickness+.2);
		translate([WheelmountWidth,0,0]) cylinder(r=MountholeR, h=PlateThickness+.2);
		translate([0,WheelmountLength,0]) cylinder(r=MountholeR, h=PlateThickness+.2);
		translate([WheelmountWidth,WheelmountLength,0]) cylinder(r=MountholeR, h=PlateThickness+.2);

		//Motor mounting holes
		translate([0,MotormountYoffset,0]) union()
		{
			translate([WheelmountWidth/2-MotormountWidth/2,0,0]) cylinder(r=MountholeR, h=PlateThickness+.2);
			translate([WheelmountWidth/2+MotormountWidth/2,0,0]) cylinder(r=MountholeR, h=PlateThickness+.2);
			translate([WheelmountWidth/2-MotormountWidth/2,MotormountLength,0]) cylinder(r=MountholeR, h=PlateThickness+.2);
			translate([WheelmountWidth/2+MotormountWidth/2,MotormountLength,0]) cylinder(r=MountholeR, h=PlateThickness+.2);
		}
	}
}