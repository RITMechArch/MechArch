% Bryan Blakeslee
% 7-8-13
% Plots of natural response of H-Bridge active braking system.

% Workspace setup
clc;
clear all;
close all;

% Parameters
Rt=0.5;     % Total resistance, ohms
Rr=0.2;     % Transistor resistance, ohms
L=750e-6;   % Inductance, henry
Iss=3;      % Steady state current, amps

% Natural response
tau=L/Rt;
t=0:0.00001:7*tau;
current=Iss.*exp(-t./tau);
vResistor=Rr.*current;
vInductor=-1.5.*exp(-(2000/3).*t);
pResistor=current.^2*Rr;

% Plot current
figure;
plot(t,current);
title('Natural Response of Current');
xlabel('Time [s]');
ylabel('Current [A]');
grid on;

% Plot voltage across transistors
figure;
plot(t,vResistor);
title('Natural Response of Voltage Across Transistors');
xlabel('Time [s]');
ylabel('Voltage [V]');
grid on;

% Plot voltage across inductor
figure;
plot(t,vInductor);
title('Natural Response of Voltage Across Inductor');
xlabel('Time [s]');
ylabel('Voltage [V]');
grid on;

% Plot power dissipated by transistors
figure;
plot(t,pResistor);
title('Power Dissipation in Transistors');
xlabel('Time [s]');
ylabel('Power [W]');
grid on;