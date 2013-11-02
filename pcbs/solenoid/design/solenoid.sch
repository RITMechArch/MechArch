v 20110115 2
C 47600 48800 1 90 0 NJM12904D.sym
{
T 46300 50400 5 10 1 1 90 3 1
refdes=IC1
T 47600 48800 5 10 0 0 0 0 1
footprint=DIP8
}
C 48400 48400 1 0 0 r.sym
{
T 48600 48600 5 10 1 1 0 0 1
refdes=R1
T 48800 48500 5 10 0 1 0 0 1
device=r
T 48500 48300 5 10 1 1 0 0 1
value=300
T 48400 48400 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 49600 46600 1 0 0 VO3120.sym
{
T 50800 47900 5 10 1 1 0 3 1
refdes=IC2
T 49600 46600 5 10 0 0 0 0 1
footprint=DIP8
}
C 52500 47800 1 0 0 r.sym
{
T 52700 48000 5 10 1 1 0 0 1
refdes=R2
T 52900 47900 5 10 0 1 0 0 1
device=r
T 52700 47600 5 10 1 1 0 0 1
value=12
T 52500 47800 5 10 0 0 0 0 1
footprint=TO220R.fp
}
C 53700 47400 1 0 0 power-nmos.sym
{
T 54400 48050 5 10 0 1 0 0 1
device=pwr-nfet
T 54400 47850 5 10 1 1 0 0 1
refdes=M1
T 53700 47400 5 10 0 0 0 0 1
footprint=TO220W
}
N 45700 48800 45700 48500 4
N 45700 48500 48400 48500 4
N 49000 48500 49600 48500 4
N 52000 48100 52000 47700 4
N 52500 47900 52000 47900 4
N 53100 47900 53700 47900 4
N 45700 48800 46100 48800 4
C 45600 46800 1 0 1 connector2-2.sym
{
T 44900 48100 5 10 1 1 0 0 1
refdes=TB2
T 45300 48050 5 10 0 0 0 6 1
device=CONNECTOR_2
T 45300 48250 5 10 0 0 0 6 1
footprint=TE-Barrier-2Pos.fp
}
N 45600 47600 46500 47600 4
N 46500 47600 46500 48800 4
C 45700 46600 1 0 0 gnd-1.sym
{
T 45900 46500 5 10 1 1 0 0 1
netname=SGND:2
}
C 46800 47900 1 0 0 gnd-1.sym
{
T 47000 47800 5 10 1 1 0 0 1
net=SGND:2
}
C 49200 47500 1 0 0 gnd-1.sym
{
T 48500 47400 5 10 1 1 0 0 1
net=SGND:2
}
N 46900 48800 46900 48200 4
N 45800 46900 45800 47200 4
N 45800 47200 45600 47200 4
N 49300 47800 49300 48100 4
N 49300 48100 49600 48100 4
C 45000 52100 1 0 1 connector2-2.sym
{
T 44300 53400 5 10 1 1 0 0 1
refdes=TB1
T 44700 53350 5 10 0 0 0 6 1
device=CONNECTOR_2
T 44700 53550 5 10 0 0 0 6 1
footprint=TE-Barrier-2Pos.fp
}
N 45000 52900 45700 52900 4
N 45700 52900 45700 51900 4
C 45100 51900 1 0 0 gnd-1.sym
{
T 44400 51800 5 10 1 1 0 0 1
net=SGND:2
}
N 45000 52500 45200 52500 4
N 45200 52500 45200 52200 4
C 54100 46800 1 0 0 gnd-1.sym
{
T 54300 46700 5 10 1 1 0 0 1
net=PGND:1
}
N 54200 47100 54200 47500 4
C 53800 49000 1 0 1 connector2-2.sym
{
T 53100 50300 5 10 1 1 0 0 1
refdes=TB4
T 53500 50250 5 10 0 0 0 6 1
device=CONNECTOR_2
T 53500 50450 5 10 0 0 0 6 1
footprint=TE-Barrier-2Pos.fp
}
C 51100 51900 1 0 1 connector2-2.sym
{
T 50400 53200 5 10 1 1 0 0 1
refdes=TB3
T 50800 53150 5 10 0 0 0 6 1
device=CONNECTOR_2
T 50800 53350 5 10 0 0 0 6 1
footprint=TE-Barrier-2Pos.fp
}
N 51100 52700 54200 52700 4
N 54200 52700 54200 51900 4
N 54200 49800 54200 51600 4
N 54200 50500 55400 50500 4
N 55400 49600 55400 50500 4
N 55400 48700 55400 49300 4
N 55400 48700 54200 48700 4
N 54200 48300 54200 49400 4
N 53800 49800 54200 49800 4
N 53800 49400 54200 49400 4
C 51300 51700 1 0 0 gnd-1.sym
{
T 50600 51600 5 10 1 1 0 0 1
net=PGND:1
}
N 51100 52300 51400 52300 4
N 51400 52300 51400 52000 4
T 43500 52900 9 10 1 0 0 0 1
+12V(S)
T 43700 52500 9 10 1 0 0 0 1
SGND
T 44300 47100 9 10 1 0 0 0 1
SGND
T 44500 47600 9 10 1 0 0 0 1
EN
C 47600 51600 1 0 0 gnd-1.sym
{
T 47800 51500 5 10 1 1 0 0 1
net=SGND:2
}
N 46500 51900 47700 51900 4
N 52000 48500 52000 52700 4
C 52200 46700 1 0 0 gnd-1.sym
{
T 52400 46600 5 10 1 1 0 0 1
net=PGND:1
}
N 52000 47300 52300 47300 4
N 52300 47300 52300 47000 4
T 49600 52700 9 10 1 0 0 0 1
+12V(P)
T 49800 52300 9 10 1 0 0 0 1
PGND
T 52600 49800 9 10 1 0 0 0 1
POS
T 52600 49400 9 10 1 0 0 0 1
NEG
C 53500 46900 1 90 0 r.sym
{
T 53300 47300 5 10 1 1 180 0 1
refdes=R3
T 53400 47300 5 10 0 1 90 0 1
device=r
T 53500 47100 5 10 1 1 0 0 1
value=500
T 53500 46900 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 53100 46100 1 0 0 led.sym
{
T 53375 46450 5 10 0 1 0 0 1
device=led
T 53100 46400 5 10 1 1 0 0 1
refdes=D3
T 53100 46100 5 10 0 0 0 0 1
footprint=LED 100
}
C 53300 45800 1 0 0 gnd-1.sym
{
T 53500 45700 5 10 1 1 0 0 1
net=PGND:1
}
N 53400 47500 53400 47900 4
N 53400 46700 53400 46900 4
N 53400 46100 53400 46200 4
C 46000 52400 1 0 0 capacitor-1.sym
{
T 46200 53100 5 10 0 0 0 0 1
device=CAPACITOR
T 46300 52900 5 10 1 1 0 0 1
refdes=C1
T 46200 53300 5 10 0 0 0 0 1
symversion=0.1
T 46300 52200 5 10 1 1 0 0 1
value=1u
T 46000 52400 5 10 0 0 0 0 1
footprint=ACY100
}
C 50800 49300 1 0 0 capacitor-1.sym
{
T 51000 50000 5 10 0 0 0 0 1
device=CAPACITOR
T 51100 49800 5 10 1 1 0 0 1
refdes=C2
T 51000 50200 5 10 0 0 0 0 1
symversion=0.1
T 51100 49100 5 10 1 1 0 0 1
value=1u
T 50800 49300 5 10 0 0 0 0 1
footprint=ACY100
}
C 47300 52300 1 0 0 gnd-1.sym
{
T 47500 52200 5 10 1 1 0 0 1
net=SGND:2
}
C 50100 49100 1 0 0 gnd-1.sym
{
T 50300 49000 5 10 1 1 0 0 1
net=PGND:1
}
N 46000 52600 45700 52600 4
N 46900 52600 47400 52600 4
N 51700 49500 52000 49500 4
N 50200 49400 50200 49500 4
N 50200 49500 50800 49500 4
C 56100 50100 1 270 0 RSX1001T3.sym
{
T 56550 49600 5 10 0 1 270 0 1
device=RSX1001T3
T 56400 49000 5 10 1 1 0 0 1
refdes=D2
T 56100 50100 5 10 0 0 0 0 1
footprint=TO220W
}
C 55000 52100 1 270 0 RSX1001T3.sym
{
T 55450 51600 5 10 0 1 270 0 1
device=RSX1001T3
T 55300 51000 5 10 1 1 0 0 1
refdes=D1
T 55000 52100 5 10 0 0 0 0 1
footprint=TO220W
}
N 56200 49600 55400 49600 4
N 56200 49900 55800 49900 4
N 55800 49900 55800 49300 4
N 55400 49300 56200 49300 4
N 54200 51900 55100 51900 4
N 54600 51900 54600 51300 4
N 54600 51300 55100 51300 4
N 55100 51600 54200 51600 4
