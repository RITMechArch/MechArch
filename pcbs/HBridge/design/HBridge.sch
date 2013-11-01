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
C 55600 46600 1 180 0 ATTINY13A.sym
{
T 54200 45300 5 10 1 1 180 3 1
refdes=IC1
T 55600 46600 5 10 0 0 180 6 1
footprint=DIP8
}
C 59200 46800 1 90 1 NJM12904D.sym
{
T 57900 45200 5 10 1 1 0 3 1
refdes=IC2
T 59200 46800 5 10 0 0 180 6 1
footprint=DIP8
}
C 56000 46200 1 0 1 gnd-1.sym
{
T 55700 46000 5 10 1 1 0 0 1
net=SGND:2
}
C 59200 46500 1 0 0 gnd-1.sym
{
T 59000 46300 5 10 1 1 0 0 1
net=SGND:2
}
C 59900 42500 1 0 0 gnd-1.sym
{
T 59200 42500 5 10 1 1 0 0 1
net=SGND:2
}
C 54700 42900 1 0 1 lm7805-1.sym
{
T 53100 44200 5 10 0 0 0 6 1
device=7805
T 53700 43900 5 10 1 1 0 0 1
refdes=VR1
T 54700 42900 5 10 0 0 0 6 1
footprint=TO220W
}
C 54000 42500 1 0 1 gnd-1.sym
{
T 53700 42300 5 10 1 1 0 0 1
net=SGND:2
}
N 53900 42800 53900 42900 4
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
N 44700 43500 44600 43500 4
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
C 55800 45600 1 0 0 r.sym
{
T 56000 45800 5 10 1 1 0 0 1
refdes=R13
T 56200 45700 5 10 0 1 0 0 1
device=r
T 56000 45500 5 10 1 1 0 0 1
value=250
T 55800 45600 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
}
C 55900 44800 1 0 0 r.sym
{
T 56100 45000 5 10 1 1 0 0 1
refdes=R14
T 56300 44900 5 10 0 1 0 0 1
device=r
T 56100 44700 5 10 1 1 0 0 1
value=250
T 55900 44800 5 10 0 0 0 0 1
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
T 41800 42100 5 10 1 1 90 2 1
net=PGND:1
}
C 52500 44600 1 90 1 capacitor-1.sym
{
T 51800 44400 5 10 0 0 90 6 1
device=CAPACITOR
T 52000 44400 5 10 1 1 180 6 1
refdes=C5
T 51600 44400 5 10 0 0 90 6 1
symversion=0.1
T 52000 44000 5 10 1 1 180 6 1
value=1u
T 52500 44600 5 10 0 0 90 6 1
footprint=ACY100
}
C 57500 43100 1 90 1 capacitor-1.sym
{
T 56800 42900 5 10 0 0 90 6 1
device=CAPACITOR
T 57000 42900 5 10 1 1 180 6 1
refdes=C6
T 56600 42900 5 10 0 0 90 6 1
symversion=0.1
T 57000 42500 5 10 1 1 180 6 1
value=1u
T 57500 43100 5 10 0 0 90 6 1
footprint=ACY100
}
N 59800 45600 60100 45600 4
C 57400 41800 1 0 1 gnd-1.sym
{
T 57500 41600 5 10 1 1 0 6 1
net=SGND:2
}
C 52400 43300 1 0 1 gnd-1.sym
{
T 52100 43100 5 10 1 1 0 0 1
net=SGND:2
}
N 57300 42200 57300 42100 4
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
N 42600 46300 42600 47800 4
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
N 42600 42200 42600 43700 4
C 44300 46300 1 90 1 power-nmos.sym
{
T 43650 45600 5 10 0 1 270 2 1
device=pwr-nfet
T 43750 45300 5 10 1 1 90 2 1
refdes=M3
T 44300 46300 5 10 0 0 270 2 1
footprint=TO220W
}
N 43800 46300 43800 47300 4
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
N 43800 42700 43800 43700 4
N 44300 44200 44200 44200 4
N 55600 45900 55600 46500 4
N 55600 46500 55900 46500 4
N 52300 44700 52900 44700 4
N 52800 44700 52800 43500 4
N 52800 43500 53100 43500 4
T 40700 41100 9 10 1 0 90 2 1
+12V(P)
T 41100 41300 9 10 1 0 90 2 1
PGND
N 57700 43700 58100 43700 4
N 58500 46800 59300 46800 4
N 58100 46800 58100 47000 4
N 58100 47000 59800 47000 4
N 59800 47000 59800 45600 4
T 60900 45600 9 10 1 0 0 0 1
FWD
T 60900 42900 9 10 1 0 0 0 1
SGND
T 60900 45200 9 10 1 0 0 0 1
REV
T 60900 43300 9 10 1 0 0 0 1
+12V(S)
N 54700 43300 60100 43300 4
N 56700 46800 57700 46800 4
N 55800 45700 55800 45500 4
N 55800 45500 55600 45500 4
N 55800 45100 55600 45100 4
N 56700 44900 56700 46800 4
N 54700 43300 54700 43500 4
N 57300 43700 57300 43300 4
N 57300 43300 57300 43100 4
N 41400 42700 41200 42700 4
N 41200 42700 41200 42600 4
N 52300 44600 52300 44700 4
N 52300 43600 52300 43700 4
C 60100 44800 1 0 0 connector2-2.sym
{
T 60800 46100 5 10 1 1 0 6 1
refdes=TB3
T 60400 46050 5 10 0 0 0 0 1
device=CONNECTOR_2
T 60400 46250 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
C 60100 42500 1 0 0 connector2-2.sym
{
T 60800 43800 5 10 1 1 0 6 1
refdes=TB4
T 60400 43750 5 10 0 0 0 0 1
device=CONNECTOR_2
T 60400 43950 5 10 0 0 0 0 1
footprint=TE-Barrier-2Pos.fp
}
N 60100 42900 60000 42900 4
N 60000 42900 60000 42800 4
N 58500 43700 59800 43700 4
N 59800 43700 59800 45200 4
N 59800 45200 60100 45200 4
N 56600 45700 56400 45700 4
N 56700 44900 56500 44900 4
N 56600 45700 56600 43600 4
N 56600 43600 57700 43600 4
N 57700 43600 57700 43700 4
C 44600 45900 1 90 1 gnd-1.sym
{
T 44700 45600 5 10 1 1 90 2 1
net=PGND:1
}
C 44600 44300 1 90 1 gnd-1.sym
{
T 44700 44000 5 10 1 1 90 2 1
net=PGND:1
}
N 43800 43500 44000 43500 4
N 42400 43500 42600 43500 4
N 44000 46500 43800 46500 4
N 42600 46500 42400 46500 4
N 40800 42600 40800 46500 4
C 45400 47400 1 180 0 r.sym
{
T 45200 47500 5 10 1 1 180 0 1
refdes=R7
T 45000 47300 5 10 0 1 180 0 1
device=r
T 45200 47200 5 10 1 1 180 0 1
value=12
T 45400 47400 5 10 0 0 180 0 1
footprint=TO220R.fp
}
C 44700 47900 1 180 0 r.sym
{
T 44500 48000 5 10 1 1 180 0 1
refdes=R5
T 44300 47800 5 10 0 1 180 0 1
device=r
T 44500 47700 5 10 1 1 180 0 1
value=12
T 44700 47900 5 10 0 0 180 0 1
footprint=TO220R.fp
}
C 44700 42600 1 0 0 r.sym
{
T 44900 42800 5 10 1 1 0 0 1
refdes=R8
T 45100 42700 5 10 0 1 0 0 1
device=r
T 44900 42500 5 10 1 1 0 0 1
value=12
T 44700 42600 5 10 0 0 0 0 1
footprint=TO220R.fp
}
C 43900 42100 1 0 0 r.sym
{
T 44100 42300 5 10 1 1 0 0 1
refdes=R6
T 44300 42200 5 10 0 1 0 0 1
device=r
T 44100 42000 5 10 1 1 0 0 1
value=12
T 43900 42100 5 10 0 0 0 0 1
footprint=TO220R.fp
}
N 45300 42700 46000 42700 4
N 44700 42700 43800 42700 4
N 42600 47800 44100 47800 4
N 44700 47800 46000 47800 4
N 43800 47300 44800 47300 4
N 45400 47300 46000 47300 4
C 50300 49300 1 180 0 VO3120.sym
{
T 49100 48000 5 10 1 1 180 3 1
refdes=IC3
T 50300 49300 5 10 0 0 0 0 1
footprint=DIP8
}
C 50300 47100 1 180 0 VO3120.sym
{
T 49100 45800 5 10 1 1 180 3 1
refdes=IC4
T 50300 47100 5 10 0 0 0 0 1
footprint=DIP8
}
C 50300 44900 1 180 0 VO3120.sym
{
T 49100 43600 5 10 1 1 180 3 1
refdes=IC5
T 50300 44900 5 10 0 0 0 0 1
footprint=DIP8
}
C 50300 42700 1 180 0 VO3120.sym
{
T 49100 41400 5 10 1 1 180 3 1
refdes=IC6
T 50300 42700 5 10 0 0 0 0 1
footprint=DIP8
}
C 50400 47300 1 0 0 r.sym
{
T 50600 47500 5 10 1 1 0 0 1
refdes=R9
T 50800 47400 5 10 0 1 0 0 1
device=r
T 50400 47300 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
T 50600 47200 5 10 1 1 0 0 1
value=300
}
C 50400 45100 1 0 0 r.sym
{
T 50600 45300 5 10 1 1 0 0 1
refdes=R10
T 50800 45200 5 10 0 1 0 0 1
device=r
T 50400 45100 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
T 50600 45000 5 10 1 1 0 0 1
value=300
}
C 50400 42900 1 0 0 r.sym
{
T 50600 43100 5 10 1 1 0 0 1
refdes=R11
T 50800 43000 5 10 0 1 0 0 1
device=r
T 50400 42900 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
T 50600 42800 5 10 1 1 0 0 1
value=300
}
C 50400 40700 1 0 0 r.sym
{
T 50600 40900 5 10 1 1 0 0 1
refdes=R12
T 50800 40800 5 10 0 1 0 0 1
device=r
T 50400 40700 5 10 0 0 0 0 1
footprint=AXIAL_LAY 300
T 50600 40600 5 10 1 1 0 0 1
value=300
}
N 50300 40800 50400 40800 4
N 50300 43000 50400 43000 4
N 50300 45200 50400 45200 4
N 50300 47400 50400 47400 4
C 51100 47900 1 90 1 gnd-1.sym
{
T 51300 47600 5 10 1 1 90 0 1
net=SGND:2
}
C 51100 45700 1 90 1 gnd-1.sym
{
T 51300 45400 5 10 1 1 90 0 1
net=SGND:2
}
C 51100 43500 1 90 1 gnd-1.sym
{
T 51300 43200 5 10 1 1 90 0 1
net=SGND:2
}
C 51100 41300 1 90 1 gnd-1.sym
{
T 51300 41000 5 10 1 1 90 0 1
net=SGND:2
}
N 50300 41200 50800 41200 4
N 50300 43400 50800 43400 4
N 50300 45600 50800 45600 4
N 50300 47800 50800 47800 4
N 47900 48200 47900 47800 4
N 47900 46000 47900 45600 4
N 47900 43800 47900 43400 4
N 47900 41600 47900 41200 4
N 47900 48000 46000 48000 4
N 46000 48000 46000 47800 4
N 47900 45800 46000 45800 4
N 46000 45800 46000 47300 4
N 47900 43600 46000 43600 4
N 46000 43600 46000 42700 4
N 47900 41400 46000 41400 4
C 47400 48300 1 0 1 gnd-1.sym
{
T 47100 48200 5 10 1 1 0 2 1
net=PGND:1
}
C 47400 46100 1 0 1 gnd-1.sym
{
T 47100 46000 5 10 1 1 0 2 1
net=PGND:1
}
C 47400 43900 1 0 1 gnd-1.sym
{
T 47100 43800 5 10 1 1 0 2 1
net=PGND:1
}
C 47400 41700 1 0 1 gnd-1.sym
{
T 47100 41600 5 10 1 1 0 2 1
net=PGND:1
}
N 47300 48600 47900 48600 4
N 47900 46400 47300 46400 4
N 47900 44200 47300 44200 4
N 47900 42000 47300 42000 4
N 42300 40800 47900 40800 4
N 46600 43000 47900 43000 4
N 46600 45200 47900 45200 4
N 46600 47400 47900 47400 4
C 46800 39900 1 90 0 capacitor-1.sym
{
T 46100 40100 5 10 0 0 90 0 1
device=CAPACITOR
T 46500 40600 5 10 1 1 180 0 1
refdes=C4
T 45900 40100 5 10 0 0 90 0 1
symversion=0.1
T 46300 40100 5 10 1 1 0 0 1
value=1u
T 46800 39900 5 10 0 0 0 0 1
footprint=ACY100
}
C 46800 42100 1 90 0 capacitor-1.sym
{
T 46100 42300 5 10 0 0 90 0 1
device=CAPACITOR
T 46500 42800 5 10 1 1 180 0 1
refdes=C3
T 45900 42300 5 10 0 0 90 0 1
symversion=0.1
T 46300 42300 5 10 1 1 0 0 1
value=1u
T 46800 42100 5 10 0 0 0 0 1
footprint=ACY100
}
C 46800 44300 1 90 0 capacitor-1.sym
{
T 46100 44500 5 10 0 0 90 0 1
device=CAPACITOR
T 46500 45000 5 10 1 1 180 0 1
refdes=C2
T 45900 44500 5 10 0 0 90 0 1
symversion=0.1
T 46300 44500 5 10 1 1 0 0 1
value=1u
T 46800 44300 5 10 0 0 0 0 1
footprint=ACY100
}
C 46800 46500 1 90 0 capacitor-1.sym
{
T 46100 46700 5 10 0 0 90 0 1
device=CAPACITOR
T 46500 47200 5 10 1 1 180 0 1
refdes=C1
T 45900 46700 5 10 0 0 90 0 1
symversion=0.1
T 46300 46700 5 10 1 1 0 0 1
value=1u
T 46800 46500 5 10 0 0 0 0 1
footprint=ACY100
}
C 46700 39500 1 0 1 gnd-1.sym
{
T 46200 39400 5 10 1 1 0 2 1
net=PGND:1
}
C 46700 41700 1 0 1 gnd-1.sym
{
T 46200 41600 5 10 1 1 0 2 1
net=PGND:1
}
C 46700 43900 1 0 1 gnd-1.sym
{
T 46200 43800 5 10 1 1 0 2 1
net=PGND:1
}
C 46700 46100 1 0 1 gnd-1.sym
{
T 46200 46000 5 10 1 1 0 2 1
net=PGND:1
}
N 46600 39800 46600 39900 4
N 46600 42100 46600 42000 4
N 46600 44300 46600 44200 4
N 46600 46500 46600 46400 4
N 47000 47400 47000 45200 4
N 47000 45200 47000 43000 4
N 47000 43000 47000 40800 4
N 52900 45900 51400 45900 4
N 51400 45900 51400 45200 4
N 51400 45200 51000 45200 4
N 52900 45500 51600 45500 4
N 51600 45500 51600 43000 4
N 51600 43000 51000 43000 4
N 52900 45100 51800 45100 4
N 51800 45100 51800 40800 4
N 51800 40800 51000 40800 4
N 55600 44700 55600 44100 4
N 55600 44100 52600 44100 4
N 52600 44100 52600 47400 4
N 52600 47400 51000 47400 4
N 40800 42900 42300 42900 4
N 42300 42900 42300 40800 4
N 42600 42200 43900 42200 4
N 44500 42200 46000 42200 4
N 46000 42200 46000 41400 4
T 61300 45600 9 10 1 0 0 0 1
(D/S)
T 61300 45200 9 10 1 0 0 0 1
(EN)
N 55800 45100 55800 44900 4
N 55800 44900 55900 44900 4
N 55900 44700 55900 44900 4
C 56000 43400 1 0 1 gnd-1.sym
{
T 56700 43400 5 10 1 1 0 6 1
net=SGND:2
}
N 55900 43800 55900 43700 4
C 56100 43800 1 90 0 capacitor-1.sym
{
T 55400 44000 5 10 0 0 90 0 1
device=CAPACITOR
T 56300 44500 5 10 1 1 180 0 1
refdes=C7
T 55200 44000 5 10 0 0 90 0 1
symversion=0.1
T 56100 44100 5 10 1 1 0 0 1
value=10n
T 56100 43800 5 10 0 0 0 0 1
footprint=ACY100
}
