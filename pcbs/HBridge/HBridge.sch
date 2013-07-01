v 20110115 2
C 40000 40000 0 0 0 title-B.sym
C 44300 50100 1 180 0 jumper-1.sym
{
T 44000 49600 5 8 0 0 180 0 1
device=JUMPER
T 44000 49600 5 10 1 1 180 0 1
refdes=TB1
T 44300 50100 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
C 43700 48000 1 270 0 jumper-1.sym
{
T 44200 47700 5 8 0 0 270 0 1
device=JUMPER
T 44000 47600 5 10 1 1 0 0 1
refdes=TB2
T 43700 48000 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
T 50000 40700 9 10 1 0 0 0 1
H-Bridge Motor Controller
T 50000 40400 9 10 1 0 0 0 1
HBridge.sch
T 50500 40100 9 10 1 0 0 0 1
1
T 52000 40100 9 10 1 0 0 0 1
1
T 53900 40400 9 10 1 0 0 0 1
1
T 53900 40100 9 10 1 0 0 0 1
Bryan Blakeslee
T 52500 50400 9 10 1 0 0 0 2
NOTE:  CHECK CUSTOM SYMBOLS FOR PINOUT!
DIODES AND TRANSISTORS!
N 44200 49100 44200 49000 4
N 43400 49000 45000 49000 4
N 44700 47900 45000 47900 4
N 43700 47900 43400 47900 4
N 45000 46800 43400 46800 4
C 45900 40900 1 90 0 MIC4467ZN.sym
{
T 44000 42200 5 10 1 1 180 3 1
refdes=IC1
T 45900 40900 5 10 0 0 0 0 1
footprint=DIP14
}
C 50700 42200 1 0 1 ATTINY13A.sym
{
T 49300 43500 5 10 1 1 0 3 1
refdes=IC2
T 50700 42200 5 10 0 0 0 0 1
footprint=DIP8
}
C 54800 42400 1 90 0 NJM12904D.sym
{
T 53500 44000 5 10 1 1 180 3 1
refdes=IC3
T 54800 42400 5 10 0 0 0 0 1
footprint=DIP8
}
C 55100 42700 1 0 0 connector3-2.sym
{
T 55800 44400 5 10 1 1 0 6 1
refdes=TB3
T 55400 44350 5 10 0 0 0 0 1
device=CONNECTOR_3
T 55100 42700 5 10 0 0 0 0 1
footprint=TE-Barrier-3Pos.fp
}
C 44100 45500 1 0 0 gnd-1.sym
C 45200 40600 1 0 0 gnd-1.sym
C 45700 43100 1 0 0 gnd-1.sym
C 50800 42500 1 0 1 gnd-1.sym
C 54000 42000 1 0 0 gnd-1.sym
C 54900 43200 1 0 0 gnd-1.sym
N 45200 40900 45300 40900 4
N 45800 43600 44800 43600 4
N 44800 43400 44800 43600 4
N 45200 43400 45200 43600 4
N 45800 43400 45800 43600 4
N 50700 42800 50700 42900 4
N 54100 42400 54100 42300 4
N 55100 43500 55000 43500 4
C 45800 49700 1 0 0 lm7805-1.sym
{
T 47400 51000 5 10 0 0 0 0 1
device=7805
T 46800 50700 5 10 1 1 0 6 1
refdes=VR1
T 45800 49700 5 10 0 0 0 0 1
footprint=TO220W
}
C 46500 49300 1 0 0 gnd-1.sym
N 46600 49600 46600 49700 4
N 47500 44100 48000 44100 4
C 42800 49300 1 90 0 r.sym
{
T 42600 49700 5 10 1 1 180 0 1
refdes=R1
T 42700 49700 5 10 0 1 90 0 1
device=r
T 42800 49500 5 10 1 1 0 0 1
value=500
T 42800 49300 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 45800 46500 1 90 0 r.sym
{
T 45600 46900 5 10 1 1 180 0 1
refdes=R4
T 45700 46900 5 10 0 1 90 0 1
device=r
T 45800 46700 5 10 1 1 0 0 1
value=500
T 45800 46500 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 45800 49300 1 90 0 r.sym
{
T 45600 49700 5 10 1 1 180 0 1
refdes=R2
T 45700 49700 5 10 0 1 90 0 1
device=r
T 45800 49500 5 10 1 1 0 0 1
value=500
T 45800 49300 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 42800 46500 1 90 0 r.sym
{
T 42600 46900 5 10 1 1 180 0 1
refdes=R3
T 42700 46900 5 10 0 1 90 0 1
device=r
T 42800 46700 5 10 1 1 0 0 1
value=500
T 42800 46500 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 43600 45500 1 90 0 r.sym
{
T 43400 45900 5 10 1 1 180 0 1
refdes=R5
T 43500 45900 5 10 0 1 90 0 1
device=r
T 43600 45700 5 10 1 1 0 0 1
value=500
T 43600 45500 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 42400 48600 1 0 0 led.sym
{
T 42675 48950 5 10 0 1 0 0 1
device=led
T 42400 48900 5 10 1 1 0 0 1
refdes=D1
T 42400 48600 5 10 0 0 0 0 1
footprint=LED 100
}
C 42400 45800 1 0 0 led.sym
{
T 42675 46150 5 10 0 1 0 0 1
device=led
T 42400 46100 5 10 1 1 0 0 1
refdes=D3
T 42400 45800 5 10 0 0 0 0 1
footprint=LED 100
}
C 43200 44800 1 0 0 led.sym
{
T 43475 45150 5 10 0 1 0 0 1
device=led
T 43200 45100 5 10 1 1 0 0 1
refdes=D5
T 43200 44800 5 10 0 0 0 0 1
footprint=LED 100
}
C 45400 45800 1 0 0 led.sym
{
T 45675 46150 5 10 0 1 0 0 1
device=led
T 45400 46100 5 10 1 1 0 0 1
refdes=D4
T 45400 45800 5 10 0 0 0 0 1
footprint=LED 100
}
C 45400 48600 1 0 0 led.sym
{
T 45675 48950 5 10 0 1 0 0 1
device=led
T 45400 48900 5 10 1 1 0 0 1
refdes=D2
T 45400 48600 5 10 0 0 0 0 1
footprint=LED 100
}
N 42700 49200 42700 49300 4
N 45700 49200 45700 49300 4
N 42700 46500 42700 46400 4
N 43500 46100 43500 46300 4
N 43500 45400 43500 45500 4
N 45700 46400 45700 46500 4
N 42700 47100 42700 48700 4
N 45700 47100 45700 48700 4
N 41600 50300 45800 50300 4
N 42700 50300 42700 49900 4
N 44200 50100 44200 50300 4
N 45700 49900 45700 50300 4
C 42600 45500 1 0 0 gnd-1.sym
C 45600 45500 1 0 0 gnd-1.sym
N 42700 45800 42700 45900 4
N 45700 45800 45700 45900 4
C 43400 44500 1 0 0 gnd-1.sym
N 43500 44900 43500 44800 4
N 42800 43400 42800 43800 4
N 42800 43800 42000 43800 4
N 42000 43800 42000 50300 4
N 43200 43400 43200 44000 4
N 43200 44000 42200 44000 4
N 42200 44000 42200 47900 4
N 43600 43400 43600 44200 4
N 43600 44200 43000 44200 4
N 43000 44200 43000 46300 4
N 44000 43400 44000 44000 4
N 44000 44000 46200 44000 4
N 46200 44000 46200 47900 4
N 46200 47900 45700 47900 4
N 42700 47900 42200 47900 4
N 42800 40900 43200 40900 4
N 43600 40900 44000 40900 4
N 44400 40900 44800 40900 4
N 46200 43700 46200 40500 4
N 46200 40500 44600 40500 4
N 44600 40500 44600 40900 4
N 46400 43300 46400 40300 4
N 46400 40300 43800 40300 4
N 43800 40300 43800 40900 4
N 46600 42900 46600 40100 4
N 46600 40100 43000 40100 4
N 43000 40100 43000 40900 4
C 46300 43600 1 0 0 r.sym
{
T 46500 43800 5 10 1 1 0 0 1
refdes=R6
T 46700 43700 5 10 0 1 0 0 1
device=r
T 46500 43500 5 10 1 1 0 0 1
value=250
T 46300 43600 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 46800 43200 1 0 0 r.sym
{
T 47000 43400 5 10 1 1 0 0 1
refdes=R7
T 47200 43300 5 10 0 1 0 0 1
device=r
T 47000 43100 5 10 1 1 0 0 1
value=250
T 46800 43200 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 47300 42800 1 0 0 r.sym
{
T 47500 43000 5 10 1 1 0 0 1
refdes=R8
T 47700 42900 5 10 0 1 0 0 1
device=r
T 47500 42700 5 10 1 1 0 0 1
value=250
T 47300 42800 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
N 46300 43700 46200 43700 4
N 46800 43300 46400 43300 4
N 47300 42900 46600 42900 4
N 47900 42900 48000 42900 4
N 47400 43300 48000 43300 4
N 46900 43700 48000 43700 4
C 51400 43600 1 0 0 r.sym
{
T 51600 43800 5 10 1 1 0 0 1
refdes=R9
T 51800 43700 5 10 0 1 0 0 1
device=r
T 51600 43500 5 10 1 1 0 0 1
value=250
T 51400 43600 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 50800 43200 1 0 0 r.sym
{
T 51000 43400 5 10 1 1 0 0 1
refdes=R10
T 51200 43300 5 10 0 1 0 0 1
device=r
T 51000 43100 5 10 1 1 0 0 1
value=250
T 50800 43200 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
N 50700 43300 50800 43300 4
N 50700 43700 51400 43700 4
N 52900 42400 53300 42400 4
N 51400 43300 51900 43300 4
N 51900 43300 51900 42200 4
N 51900 42200 52900 42200 4
N 52900 42200 52900 42400 4
N 53300 45500 53700 45500 4
N 52000 43700 52100 43700 4
N 52100 43700 52100 45700 4
N 52100 45700 53300 45700 4
N 53300 45700 53300 45500 4
C 54200 45400 1 0 0 r.sym
{
T 54400 45600 5 10 1 1 0 0 1
refdes=R11
T 54600 45500 5 10 0 1 0 0 1
device=r
T 54400 45300 5 10 1 1 0 0 1
value=250
T 54200 45400 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 54200 41800 1 0 0 r.sym
{
T 54400 42000 5 10 1 1 0 0 1
refdes=R12
T 54600 41900 5 10 0 1 0 0 1
device=r
T 54400 41700 5 10 1 1 0 0 1
value=250
T 54200 41800 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
N 53700 42400 53700 41900 4
N 53700 41900 54200 41900 4
N 54800 41900 54900 41900 4
N 54900 41900 54900 43100 4
N 54800 45500 54900 45500 4
N 54900 45500 54900 43900 4
N 54200 45500 54100 45500 4
N 52900 45500 52900 46200 4
N 47800 46200 53000 46200 4
N 47800 46200 47800 50900 4
N 47800 50900 45700 50900 4
N 45700 50900 45700 50300 4
C 41600 49500 1 0 1 connector2-2.sym
{
T 40900 50800 5 10 1 1 0 0 1
refdes=TB4
T 41300 50750 5 10 0 0 0 6 1
device=CONNECTOR_2
T 41600 49500 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
C 41500 49500 1 0 0 gnd-1.sym
N 41600 49900 41600 49800 4
N 47400 50300 47500 50300 4
N 47500 50300 47500 44100 4
C 41300 43300 1 0 0 capacitor-1.sym
{
T 41500 44000 5 10 0 0 0 0 1
device=CAPACITOR
T 41600 43800 5 10 1 1 0 0 1
refdes=C1
T 41500 44200 5 10 0 0 0 0 1
symversion=0.1
T 41600 43100 5 10 1 1 0 0 1
value=1u
T 41300 43300 5 10 0 0 0 0 1
footprint=ACY100
}
C 47600 44700 1 0 0 capacitor-1.sym
{
T 47800 45400 5 10 0 0 0 0 1
device=CAPACITOR
T 47900 45200 5 10 1 1 0 0 1
refdes=C2
T 47800 45600 5 10 0 0 0 0 1
symversion=0.1
T 47900 44500 5 10 1 1 0 0 1
value=1u
T 47600 44700 5 10 0 0 0 0 1
footprint=ACY100
}
C 53000 46000 1 0 0 capacitor-1.sym
{
T 53200 46700 5 10 0 0 0 0 1
device=CAPACITOR
T 53300 46500 5 10 1 1 0 0 1
refdes=C3
T 53200 46900 5 10 0 0 0 0 1
symversion=0.1
T 53300 45800 5 10 1 1 0 0 1
value=1u
T 53000 46000 5 10 0 0 0 0 1
footprint=ACY100
}
N 55100 43900 54900 43900 4
N 55100 43100 54900 43100 4
N 42200 43500 42800 43500 4
N 47500 44900 47600 44900 4
C 53800 45800 1 0 0 gnd-1.sym
C 48500 44600 1 0 0 gnd-1.sym
C 41100 43200 1 0 0 gnd-1.sym
N 41300 43500 41200 43500 4
N 48500 44900 48600 44900 4
N 53900 46200 53900 46100 4
C 42800 48000 1 0 0 power-pmos.sym
{
T 43450 48650 5 10 0 1 0 0 1
device=pwr-pfet
T 43600 48450 5 10 1 1 0 0 1
refdes=M1
}
N 43400 49000 43400 48900 4
N 42900 48500 42700 48500 4
C 45600 48000 1 0 1 power-pmos.sym
{
T 44950 48650 5 10 0 1 0 6 1
device=pwr-pfet
T 44800 48450 5 10 1 1 0 6 1
refdes=M2
}
N 45000 49000 45000 48900 4
N 45500 48500 45700 48500 4
C 42900 46800 1 0 0 power-nmos.sym
{
T 43600 47450 5 10 0 1 0 0 1
device=pwr-nfet
T 43600 47250 5 10 1 1 0 0 1
refdes=M3
}
N 42900 47300 42700 47300 4
N 43400 46900 43400 46800 4
N 43400 47700 43400 48100 4
C 45500 46800 1 0 1 power-nmos.sym
{
T 44800 47450 5 10 0 1 0 6 1
device=pwr-nfet
T 44800 47250 5 10 1 1 0 6 1
refdes=M4
}
N 45000 47700 45000 48100 4
N 45500 47300 45700 47300 4
N 45000 46800 45000 46900 4
C 43700 45800 1 0 0 power-nmos.sym
{
T 44400 46450 5 10 0 1 0 0 1
device=pwr-nfet
T 44400 46250 5 10 1 1 0 0 1
refdes=M5
}
N 44200 46700 44200 46800 4
N 44200 45900 44200 45800 4
N 43000 46300 43700 46300 4
