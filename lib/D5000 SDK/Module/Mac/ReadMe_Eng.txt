Nikon Type0003 Module SDK Revision.1 summary


Usage
 Control the camera.


Supported camera
 D90,D5000


Environment of operation
 [Windows]
    Windows XP Home Edition (SP3) / Professional (SP3)
    Windows Vista SP1 32bit each edition
    (Home Basic / Home Premium / Business / Enterprise / Ultimate)
    * Please set Camera to PTP mode by SET UP menu (on camera body). If the 
      camera is set to Mass Storage, you can not control it by Windows.

 [Macintosh]
    MacOS X 10.4.11
    MacOS X 10.5.5
    * Please set Camera to PTP mode by SET UP menu (on camera body). If the 
      camera is set to Mass Storage, you can not control it by Macintosh.


Contents
 [Windows]
    Documents
      MAID3(E).pdf : Basic interface specification
      MAID3Type0003(E).pdf : Extended interface specification used 
                                                             by Type0003 Module
      Usage of Type0003 Module(E).pdf : Notes for using Type0003 Module
      Type0003 Sample Guide(E).pdf : The usage of a sample program

    Binary Files(Win)
      WinXP_Vista
        Type0003.md3 : Type0003 Module for Win
        NkdPTP.dll : Driver for PTP mode used by Windows XP, Vista

    Header Files
      Maid3.h : Basic header file of MAID interface
      Maid3d1.h : Extended header file for Type0003 Module
      NkTypes.h : Definitions of the types used in Maid3.h.

    Sample Program
      Type0003CtrlSample(Win) : Project for Microsoft Visual Studio .Net 2003


 [Macintosh]
    Documents
      MAID3(E).pdf : Basic interface specification
      MAID3Type0003(E).pdf : Extended interface specification used by 
                                                                Type0003 Module
      Usage of Type0003 Module(E).pdf : Notes for using Type0003 Module
      Type0003 Sample Guide(E).pdf : The usage of a sample program

    Binary Files(Mac)
        Type0003 Module.bundle : Type0003 Module for Mac (Universal Binary)
        libNkPTPDriver.dylib : PTP driver for Mac (Universal Binary)
 
    Header Files
      Maid3.h : Basic header file of MAID interface
      Maid3d1.h : Extended header file for Type0003 Module
      NkTypes.h : Definitions of the types used in Maid3.h.

    Sample Program
      Type0003CtrlSample(Mac) : Sample program project for Xcode 2.5.
                                                             (Universal Binary)


Limitations
 This module cannot control two or more cameras.
