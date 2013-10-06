v 20110115 2
C 41000 44900 1 270 1 jumper-1.sym
{
T 41500 45200 5 8 0 0 90 2 1
device=JUMPER
T 41500 45200 5 10 1 1 90 2 1
refdes=TB1
T 41000 44900 5 10 0 0 270 2 1
footprint=TE-Barrier-2Pos.fp
}
C 43100 45500 1 180 1 jumper-1.sym
{
T 43400 45000 5 8 0 0 180 6 1
device=JUMPER
T 42900 44800 5 10 1 1 90 2 1
refdes=TB2
T 43100 45500 5 10 0 0 270 2 1
footprint=TE-Barrier-2Pos.fp
}
N 42000 45000 42100 45000 4
N 42100 45800 42100 44200 4
N 43200 44500 43200 44200 4
N 43200 45500 43200 45800 4
N 44300 44200 44300 45800 4
C 50200 43300 1 0 1 MIC4467ZN.sym
{
T 48900 45200 5 10 1 1 90 5 1
refdes=IC1
T 50200 43300 5 10 0 0 270 2 1
footprint=DIP14
}
C 56700 46600 1 180 0 ATTINY13A.sym
{
T 55300 45300 5 10 1 1 180 3 1
refdes=IC2
T 56700 46600 5 10 0 0 180 6 1
footprint=DIP8
}
C 60300 46800 1 90 1 NJM12904D.sym
{
T 59000 45200 5 10 1 1 0 3 1
refdes=IC3
T 60300 46800 5 10 0 0 180 6 1
footprint=DIP8
}
C 45600 45100 1 90 1 gnd-1.sym
{
T 45700 44700 5 10 1 1 90 2 1
net=PGND:1
}
C 50400 43600 1 0 1 gnd-1.sym
{
T 50600 43400 5 10 1 1 180 2 1
net=PGND:1
}
C 47600 43500 1 0 1 gnd-1.sym
{
T 47900 43300 5 10 1 1 180 2 1
net=PGND:1
}
C 57100 46200 1 0 1 gnd-1.sym
{
T 56800 46000 5 10 1 1 0 0 1
net=SGND:2
}
C 60300 46500 1 0 0 gnd-1.sym
{
T 60100 46300 5 10 1 1 0 0 1
net=SGND:2
}
C 61000 42500 1 0 0 gnd-1.sym
{
T 60300 42500 5 10 1 1 0 0 1
net=SGND:2
}
N 50200 44000 50300 44000 4
N 47700 44400 47500 44400 4
N 47700 44000 47500 44000 4
C 55800 42900 1 0 1 lm7805-1.sym
{
T 54200 44200 5 10 0 0 0 6 1
device=7805
T 54800 43900 5 10 1 1 0 0 1
refdes=VR1
T 55800 42900 5 10 0 0 0 6 1
footprint=TO220W
}
C 55100 42500 1 0 1 gnd-1.sym
{
T 54800 42300 5 10 1 1 0 0 1
net=SGND:2
}
N 55000 42800 55000 42900 4
C 41800 46400 1 0 1 r.sym
{
T 41400 46600 5 10 1 1 90 2 1
refdes=R1
T 41400 46500 5 10 0 1 0 6 1
device=r
T 41400 46100 5 10 1 1 90 2 1
value=500
T 41800 46400 5 10 0 0 270 2 1
footprint=AXIAL_LAY 300
}
C 44600 43400 1 0 1 r.sym
{
T 44200 43600 5 10 1 1 90 2 1
refdes=R4
T 44200 43500 5 10 0 1 0 6 1
device=r
T 44200 43100 5 10 1 1 90 2 1
value=500
T 44600 43400 5 10 0 0 270 2 1
footprint=AXIAL_LAY 300
}
C 41800 43400 1 0 1 r.sym
{
T 41400 43600 5 10 1 1 90 2 1
refdes=R2
T 41400 43500 5 10 0 1 0 6 1
device=r
T 41400 43100 5 10 1 1 90 2 1
value=500
T 41800 43400 5 10 0 0 270 2 1
footprint=AXIAL_LAY 300
}
C 44600 46400 1 0 1 r.sym
{
T 44200 46600 5 10 1 1 90 2 1
refdes=R3
T 44200 46500 5 10 0 1 0 6 1
device=r
T 44200 46100 5 10 1 1 90 2 1
value=500
T 44600 46400 5 10 0 0 270 2 1
footprint=AXIAL_LAY 300
}
C 45600 45600 1 0 1 r.sym
{
T 45200 45800 5 10 1 1 90 2 1
refdes=R5
T 45200 45700 5 10 0 1 0 6 1
device=r
T 45200 45300 5 10 1 1 90 2 1
value=500
T 45600 45600 5 10 0 0 270 2 1
footprint=AXIAL_LAY 300
}
C 42500 46800 1 90 1 led.sym
{
T 42150 46525 5 10 0 1 270 2 1
device=led
T 42100 46600 5 10 1 1 90 2 1
refdes=D1
T 42500 46800 5 10 0 0 270 2 1
footprint=LED 100
}
C 45300 46800 1 90 1 led.sym
{
T 44950 46525 5 10 0 1 270 2 1
device=led
T 44900 46600 5 10 1 1 90 2 1
refdes=D3
T 45300 46800 5 10 0 0 270 2 1
footprint=LED 100
}
C 46300 46000 1 90 1 led.sym
{
T 45950 45725 5 10 0 1 270 2 1
device=led
T 45900 45800 5 10 1 1 90 2 1
refdes=D5
T 46300 46000 5 10 0 0 270 2 1
footprint=LED 100
}
C 45300 43800 1 90 1 led.sym
{
T 44950 43525 5 10 0 1 270 2 1
device=led
T 44900 43600 5 10 1 1 90 2 1
refdes=D4
T 45300 43800 5 10 0 0 270 2 1
footprint=LED 100
}
C 42500 43800 1 90 1 led.sym
{
T 42150 43525 5 10 0 1 270 2 1
device=led
T 42100 43600 5 10 1 1 90 2 1
refdes=D2
T 42500 43800 5 10 0 0 270 2 1
footprint=LED 100
}
N 41900 46500 41800 46500 4
N 41900 43500 41800 43500 4
N 44600 46500 44700 46500 4
N 45000 45700 44800 45700 4
N 45700 45700 45600 45700 4
N 44700 43500 44600 43500 4
N 44000 46500 42400 46500 4
N 44000 43500 42400 43500 4
N 40800 46500 41200 46500 4
N 41000 45000 40800 45000 4
N 41200 43500 40800 43500 4
C 45600 46600 1 90 1 gnd-1.sym
{
T 45700 46300 5 10 1 1 90 2 1
net=PGND:1
}
C 45600 43600 1 90 1 gnd-1.sym
{
T 45700 43200 5 10 1 1 90 2 1
net=PGND:1
}
N 45300 46500 45200 46500 4
N 45300 43500 45200 43500 4
C 46600 45800 1 90 1 gnd-1.sym
{
T 46700 45400 5 10 1 1 90 2 1
net=PGND:1
}
N 46200 45700 46300 45700 4
N 47700 46400 47300 46400 4
N 47300 46400 47300 47200 4
N 47300 47200 40800 47200 4
N 47700 46000 47100 46000 4
N 47100 46000 47100 47000 4
N 47100 47000 43200 47000 4
N 47700 45600 46900 45600 4
N 46900 45600 46900 46200 4
N 46900 46200 44800 46200 4
N 47700 45200 47100 45200 4
N 47100 45200 47100 43000 4
N 47100 43000 43200 43000 4
N 43200 43000 43200 43500 4
N 43200 46500 43200 47000 4
N 50200 46400 50200 46000 4
N 50200 45600 50200 45200 4
N 50200 44800 50200 44400 4
C 56900 45600 1 0 0 r.sym
{
T 57100 45800 5 10 1 1 0 0 1
refdes=R9
T 57300 45700 5 10 0 1 0 0 1
device=r
T 57100 45500 5 10 1 1 0 0 1
value=250
T 56900 45600 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 56900 44800 1 0 0 r.sym
{
T 57100 45000 5 10 1 1 0 0 1
refdes=R10
T 57300 44900 5 10 0 1 0 0 1
device=r
T 57100 44700 5 10 1 1 0 0 1
value=250
T 56900 44800 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 41600 42600 1 90 1 connector2-2.sym
{
T 40300 41900 5 10 1 1 90 0 1
refdes=TB5
T 40350 42300 5 10 0 0 90 6 1
device=CONNECTOR_2
T 41600 42600 5 10 0 0 90 0 1
footprint=TE-Barrier-2Pos.fp
}
C 41700 42800 1 90 1 gnd-1.sym
{
T 41800 42500 5 10 1 1 90 2 1
net=PGND:1
}
C 47800 47900 1 90 1 capacitor-1.sym
{
T 47100 47700 5 10 0 0 270 2 1
device=CAPACITOR
T 47200 47400 5 10 1 1 90 2 1
refdes=C1
T 46900 47700 5 10 0 0 270 2 1
symversion=0.1
T 47900 47400 5 10 1 1 90 2 1
value=1u
T 47800 47900 5 10 0 0 270 2 1
footprint=ACY100
}
C 53600 44600 1 90 1 capacitor-1.sym
{
T 52900 44400 5 10 0 0 90 6 1
device=CAPACITOR
T 53100 44300 5 10 1 1 90 6 1
refdes=C2
T 52700 44400 5 10 0 0 90 6 1
symversion=0.1
T 53800 44300 5 10 1 1 90 6 1
value=1u
T 53600 44600 5 10 0 0 90 6 1
footprint=ACY100
}
C 58600 43100 1 90 1 capacitor-1.sym
{
T 57900 42900 5 10 0 0 90 6 1
device=CAPACITOR
T 58100 42800 5 10 1 1 90 6 1
refdes=C3
T 57700 42900 5 10 0 0 90 6 1
symversion=0.1
T 58800 42800 5 10 1 1 90 6 1
value=1u
T 58600 43100 5 10 0 0 90 6 1
footprint=ACY100
}
N 60900 45600 61200 45600 4
N 47600 47000 47600 46400 4
C 58500 41800 1 0 1 gnd-1.sym
{
T 58600 41600 5 10 1 1 0 6 1
net=SGND:2
}
C 53500 43300 1 0 1 gnd-1.sym
{
T 53200 43100 5 10 1 1 0 0 1
net=SGND:2
}
C 47900 48100 1 90 1 gnd-1.sym
{
T 48000 47800 5 10 1 1 90 2 1
net=PGND:1
}
N 47600 47900 47600 48000 4
N 58400 42200 58400 42100 4
C 43100 46400 1 90 1 power-pmos.sym
{
T 42450 45750 5 10 0 1 270 2 1
device=pwr-pfet
T 42550 45300 5 10 1 1 90 2 1
refdes=M1
T 43100 46400 5 10 0 0 270 2 1
footprint=TO220W
}
N 42100 45800 42200 45800 4
N 42600 46300 42600 46500 4
C 43100 43600 1 90 0 power-pmos.sym
{
T 42450 44250 5 10 0 1 270 8 1
device=pwr-pfet
T 42550 44700 5 10 1 1 90 8 1
refdes=M2
T 43100 43600 5 10 0 0 270 2 1
footprint=TO220W
}
N 42100 44200 42200 44200 4
N 42600 43700 42600 43500 4
C 44300 46300 1 90 1 power-nmos.sym
{
T 43650 45600 5 10 0 1 270 2 1
device=pwr-nfet
T 43750 45300 5 10 1 1 90 2 1
refdes=M3
T 44300 46300 5 10 0 0 270 2 1
footprint=TO220W
}
N 43800 46300 43800 46500 4
N 44200 45800 44300 45800 4
N 43400 45800 43000 45800 4
C 44300 43700 1 90 0 power-nmos.sym
{
T 43650 44400 5 10 0 1 270 8 1
device=pwr-nfet
T 43750 44700 5 10 1 1 90 8 1
refdes=M4
T 44300 43700 5 10 0 0 270 2 1
footprint=TO220W
}
N 43400 44200 43000 44200 4
N 43800 43700 43800 43500 4
N 44300 44200 44200 44200 4
C 45300 45500 1 90 1 power-nmos.sym
{
T 44650 44800 5 10 0 1 270 2 1
device=pwr-nfet
T 44750 44500 5 10 1 1 90 2 1
refdes=M5
T 45300 45500 5 10 0 0 270 2 1
footprint=TO220W
}
N 44400 45000 44300 45000 4
N 45200 45000 45300 45000 4
N 44800 46200 44800 45500 4
N 56700 45900 56700 46500 4
N 56700 46500 57000 46500 4
N 53400 44700 54000 44700 4
N 53900 44700 53900 43500 4
N 53900 43500 54200 43500 4
T 40700 41100 9 10 1 0 90 2 1
+12V(P)
T 41100 41300 9 10 1 0 90 2 1
PGND
N 58800 43700 59200 43700 4
N 59600 46800 60400 46800 4
N 59200 46800 59200 47000 4
N 59200 47000 60900 47000 4
N 60900 47000 60900 45600 4
T 62000 45600 9 10 1 0 0 0 1
FWD
T 62000 42900 9 10 1 0 0 0 1
SGND
T 62000 45100 9 10 1 0 0 0 1
REV
T 62000 43300 9 10 1 0 0 0 1
+12V(S)
N 55800 43300 61200 43300 4
N 57800 46800 58800 46800 4
N 56900 45700 56900 45500 4
N 56900 45500 56700 45500 4
N 56900 44900 56900 45100 4
N 56900 45100 56700 45100 4
N 57800 44900 57800 46800 4
N 55800 43300 55800 43500 4
N 58400 43700 58400 43300 4
N 58400 43300 58400 43100 4
N 50300 44000 50300 43900 4
N 47500 43800 47500 44400 4
N 41400 42700 41200 42700 4
N 41200 42700 41200 42600 4
N 40800 42600 40800 47200 4
N 53400 44600 53400 44700 4
N 53400 43600 53400 43700 4
C 61200 44800 1 0 0 connector2-2.sym
{
T 61900 46100 5 10 1 1 0 6 1
refdes=TB3
T 61500 46050 5 10 0 0 0 0 1
device=CONNECTOR_2
T 61500 46250 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
C 61200 42500 1 0 0 connector2-2.sym
{
T 61900 43800 5 10 1 1 0 6 1
refdes=TB4
T 61500 43750 5 10 0 0 0 0 1
device=CONNECTOR_2
T 61500 43950 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
N 61200 42900 61100 42900 4
N 61100 42900 61100 42800 4
N 59600 43700 60900 43700 4
N 60900 43700 60900 45200 4
N 60900 45200 61200 45200 4
N 57700 45700 57500 45700 4
N 57800 44900 57500 44900 4
N 57700 45700 57700 43600 4
N 57700 43600 58800 43600 4
N 58800 43600 58800 43700 4
