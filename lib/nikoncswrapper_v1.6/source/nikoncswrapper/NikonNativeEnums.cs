//
// This work is licensed under a Creative Commons Attribution 3.0 Unported License.
//
// Thomas Dideriksen (thomas@dideriksen.com)
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nikon
{
    // Note: This file is auto generated

    public enum eNkMAIDActive : int
    {
        kNkMAIDActive_D_Lighting_High = 0,
        kNkMAIDActive_D_Lighting_Normal = 1,
        kNkMAIDActive_D_Lighting_Low = 2,
        kNkMAIDActive_D_Lighting_Off = 3,       // OFF
        kNkMAIDActive_D_Lighting_On = 4,        // ON
        kNkMAIDActive_D_Lighting_ExtraHigh = 5,
        kNkMAIDActive_D_Lighting_Auto = 6,
        kNkMAIDActive_D_Lighting_ExtraHigh2 = 7
    }

    public enum eNkMAIDActiveSlot : int
    {
        kNkMAIDActiveSlot_NoCard = 0,
        kNkMAIDActiveSlot_Slot1 = 1,
        kNkMAIDActiveSlot_Slot2 = 2,
        kNkMAIDActiveSlot_Slot1_Slot2 = 3
    }

    public enum eNkMAIDAdaptor : int
    {
        kNkMAIDAdaptor_None = 0,            // There is no adaptor or holder. (LS4000, LS40 and LS8000)
        kNkMAIDAdaptor_MA = 65536,          // Base value for MA20, FH3 and FHG1.
        kNkMAIDAdaptor_SA = 131072,         // Base value for SA21 and SA30
        kNkMAIDAdaptor_IA = 262144,         // Base value for IA20
        kNkMAIDAdaptor_FD = 524288,         // Base value for SF200
        kNkMAIDAdaptor_LS4000 = 67108864,   // Base value for LS4000 and LS40 adaptors.
        kNkMAIDAdaptor_MA20 = 67174672,     // 35mm Mount adaptor. (LS4000 and LS40)
        kNkMAIDAdaptor_FH3 = 67174688,      // 35mm Strip film holder. (LS4000 and LS40)
        kNkMAIDAdaptor_FHA1 = 67174944,     // APS holder. (LS4000 and LS40)
        kNkMAIDAdaptor_FHG1 = 67207168,     // Medical holder. (LS4000 and LS40)
        kNkMAIDAdaptor_SA21 = 67240225,     // 35mm strip film adaptor. (LS4000 and LS40)
        kNkMAIDAdaptor_SA30 = 67240226,     // 35mm strip film adaptor. (LS4000)
        kNkMAIDAdaptor_IA20 = 67371552,     // APS film adaptor. (LS4000 and LS40)
        kNkMAIDAdaptor_SF200 = 67633424,    // 35mm slide mount adaptor. (LS4000)
        kNkMAIDAdaptor_LS8000 = 134217728,  // Base value for LS8000 adaptors.
        kNkMAIDAdaptor_FH835M = 134218000,  // 35mm Mount holder. (LS8000)
        kNkMAIDAdaptor_FH835S = 134218016,  // 35mm Strip film holder. (LS8000)
        kNkMAIDAdaptor_FH869M = 134218768,  // Brownie mount holder. (LS8000)
        kNkMAIDAdaptor_FH869S = 134218784,  // Brownie strip film holder. (LS8000)
        kNkMAIDAdaptor_FH869G = 134218786,  // Brownie strip film holder with grass. (LS8000)
        kNkMAIDAdaptor_FH869GR = 134218790, // Brownie strip film rotated holder with grass. (LS8000)
        kNkMAIDAdaptor_FH816 = 134234144,   // 16mm strip film holder. (LS8000)
        kNkMAIDAdaptor_FH8G1 = 134250496    // Medical holder. (LS8000)
    }

    public enum eNkMAIDADLBracketingStep : int
    {
        kNkMAIDADLBracketingStep_Auto = 0,
        kNkMAIDADLBracketingStep_Low = 1,
        kNkMAIDADLBracketingStep_Normal = 2,
        kNkMAIDADLBracketingStep_High = 3,
        kNkMAIDADLBracketingStep_ExtraHigh_1 = 4,
        kNkMAIDADLBracketingStep_ExtraHigh_2 = 5
    }

    public enum eNkMAIDADLBracketingType : int
    {
        kNkMAIDADLBracketingType_2 = 0,
        kNkMAIDADLBracketingType_3 = 1,
        kNkMAIDADLBracketingType_4 = 2,
        kNkMAIDADLBracketingType_5 = 3,
        kNkMAIDADLBracketingType_5_Max_ExHi2 = 4
    }

    public enum eNkMAIDAEBracketingStep : int
    {
        kNkMAIDAEBracketingStep_1_3EV = 0,
        kNkMAIDAEBracketingStep_1_2EV = 1,
        kNkMAIDAEBracketingStep_2_3EV = 2,
        kNkMAIDAEBracketingStep_1EV = 3,
        kNkMAIDAEBracketingStep_4_3EV = 4,
        kNkMAIDAEBracketingStep_3_2EV = 5,
        kNkMAIDAEBracketingStep_5_3EV = 6,
        kNkMAIDAEBracketingStep_2EV = 7,
        kNkMAIDAEBracketingStep_3EV = 8
    }

    public enum eNkMAIDAFAreaPoint : int
    {
        kNkMAIDAFAreaPoint_51 = 0,
        kNkMAIDAFAreaPoint_11 = 1,
        kNkMAIDAFAreaPoint_39 = 2
    }

    public enum eNkMAIDAfGroupAreaPatternType : int
    {
        kNkMAIDAfGroupAreaPatternType_Horizontal = 0,
        kNkMAIDAfGroupAreaPatternType_Vertical = 1
    }

    public enum eNkMAIDAFLockOnEx : int
    {
        kNkMAIDAFLockOnEx_High = 0,
        kNkMAIDAFLockOnEx_Normal = 1,
        kNkMAIDAFLockOnEx_Low = 2,
        kNkMAIDAFLockOnEx_Off = 3,
        kNkMAIDAFLockOnEx_LittleHigh = 4,
        kNkMAIDAFLockOnEx_LittleLow = 5
    }

    public enum eNkMAIDAFMode : int
    {
        kNkMAIDAFMode_S = 0,
        kNkMAIDAFMode_C = 1,
        kNkMAIDAFMode_A = 2,
        kNkMAIDAFMode_M_FIX = 3,
        kNkMAIDAFMode_M_SEL = 4
    }

    public enum eNkMAIDAFModeAtLiveView : int
    {
        kNkMAIDAFModeAtLiveView_S = 0,
        kNkMAIDAFModeAtLiveView_C = 1,
        kNkMAIDAFModeAtLiveView_F = 2,
        kNkMAIDAFModeAtLiveView_M_FIX = 3,
        kNkMAIDAFModeAtLiveView_M_SEL = 4
    }

    public enum eNkMAIDAFModeRestrictions : int
    {
        kNkMAIDAFModeRestrictions_OFF = 0,
        kNkMAIDAFModeRestrictions_AFs = 1,
        kNkMAIDAFModeRestrictions_AFc = 2
    }

    public enum eNkMAIDApertureLockSetting : int
    {
        kNkMAIDApertureLockSetting_Off = 0,
        kNkMAIDApertureLockSetting_On = 1
    }

    public enum eNkMAIDArrayType : int
    {
        kNkMAIDArrayType_Boolean = 0,      // 1 byte per element
        kNkMAIDArrayType_Integer = 1,      // signed value that is 1, 2 or 4 bytes per element
        kNkMAIDArrayType_Unsigned = 2,     // unsigned value that is 1, 2 or 4 bytes per element
        kNkMAIDArrayType_Float = 3,        // DOUB_P elements
        kNkMAIDArrayType_Point = 4,        // NkMAIDPoint structures
        kNkMAIDArrayType_Size = 5,         // NkMAIDSize structures
        kNkMAIDArrayType_Rect = 6,         // NkMAIDRect structures
        kNkMAIDArrayType_PackedString = 7, // packed array of strings
        kNkMAIDArrayType_String = 8,       // NkMAIDString structures
        kNkMAIDArrayType_DateTime = 9      // NkMAIDDateTime structures
    }

    public enum eNkMAIDAutoDistortion : int
    {
        kNkMAIDAutoDistortion_Off = 0,
        kNkMAIDAutoDistortion_On = 1
    }

    public enum eNkMAIDAutoOffTimer : int
    {
        kNkMAIDAutoOffTimer_Short = 0,
        kNkMAIDAutoOffTimer_Normal = 1,
        kNkMAIDAutoOffTimer_Long = 2,
        kNkMAIDAutoOffTimer_Custom = 3
    }

    public enum eNkMAIDBeepEx : int
    {
        kNkMAIDBeepEx_High = 0,
        kNkMAIDBeepEx_Low = 1,
        kNkMAIDBeepEx_Off = 2,
        kNkMAIDBeepEx_On = 3
    }

    public enum eNkMAIDBeepVolume : int
    {
        kNkMAIDBeepVolume_Off = 0,
        kNkMAIDBeepVolume_1 = 1,
        kNkMAIDBeepVolume_2 = 2,
        kNkMAIDBeepVolume_3 = 3
    }

    public enum eNkMAIDBlinkingStatus : int
    {
        kNkMAIDBlinkingStatus_None = 0,
        kNkMAIDBlinkingStatus_Sp_Blink = 1,
        kNkMAIDBlinkingStatus_Ap_Blink = 2,
        kNkMAIDBlinkingStatus_Both = 3
    }

    public enum eNkMAIDBooleanDefault : int
    {
        kNkMAIDBooleanDefault_None = 0,
        kNkMAIDBooleanDefault_True = 1,
        kNkMAIDBooleanDefault_False = 2
    }

    public enum eNkMAIDBracketButton : int
    {
        kNkMAIDBracketButton_AutoBracketing = 0,
        kNkMAIDBracketButton_MultipleExposur = 1
    }

    public enum eNkMAIDBracketingType : int
    {
        kNkMAIDBracketingType_Minus_2 = 0,
        kNkMAIDBracketingType_Puls_2 = 1,
        kNkMAIDBracketingType_Minus_3 = 2,
        kNkMAIDBracketingType_Puls_3 = 3,
        kNkMAIDBracketingType_Both_3 = 4,
        kNkMAIDBracketingType_Both_5 = 5,
        kNkMAIDBracketingType_Both_7 = 6,
        kNkMAIDBracketingType_Both_9 = 7
    }

    public enum eNkMAIDCameraInclination : int
    {
        kNkMAIDCameraInclination_Level = 0,
        kNkMAIDCameraInclination_GripTop = 1,
        kNkMAIDCameraInclination_GripBottom = 2,
        kNkMAIDCameraInclination_LevelUpDown = 3
    }

    public enum eNkMAIDCameraType : int
    {
        kNkMAIDCameraType_D2H_V1 = 0,    // D2H Ver.1
        kNkMAIDCameraType_D2H_V2 = 1,    // D2H Ver.2
        kNkMAIDCameraType_D2X = 2,       // D2X Ver.1
        kNkMAIDCameraType_D2HS = 3,      // D2Hs
        kNkMAIDCameraType_D2X_V2 = 4,    // D2X Ver.2
        kNkMAIDCameraType_D2XS = 5,      // D2XS
        kNkMAIDCameraType_D2HS_V2 = 6,   // D2HS Ver.2
        kNkMAIDCameraType_D40 = 16,      // D40
        kNkMAIDCameraType_D40X = 17,     // D40X
        kNkMAIDCameraType_D3 = 32,       // D3
        kNkMAIDCameraType_D300 = 33,     // D300
        kNkMAIDCameraType_D60 = 34,      // D60
        kNkMAIDCameraType_D700 = 36,     // D700
        kNkMAIDCameraType_D3_FU1 = 37,   // D3 Firmup 1
        kNkMAIDCameraType_D3_FU2 = 38,   // D3 Firmup 2
        kNkMAIDCameraType_D300_FU = 39,  // D300 Firmup
        kNkMAIDCameraType_D90 = 40,      // D90
        kNkMAIDCameraType_D5000 = 41,    // D5000
        kNkMAIDCameraType_D300S = 42,    // D300S
        kNkMAIDCameraType_D3S = 43,      // D3S
        kNkMAIDCameraType_D3_FU3 = 44,   // D3 Firmup 3
        kNkMAIDCameraType_D700_FU1 = 45, // D700 Firmup 1
        kNkMAIDCameraType_D7000 = 46,    // D7000
        kNkMAIDCameraType_D5100 = 47,    // D5100
        kNkMAIDCameraType_D800 = 48,     // D800
        kNkMAIDCameraType_D4 = 49,       // D4
        kNkMAIDCameraType_D800E = 50,    // D800E
        kNkMAIDCameraType_D600 = 51,     // D600
        kNkMAIDCameraType_D5200 = 52,    // D5200
        kNkMAIDCameraType_D7100 = 53,    // D7100
        kNkMAIDCameraType_D5300 = 54,    // D5300
        kNkMAIDCameraType_Df = 55,       // Df
        kNkMAIDCameraType_D610 = 56,     // D610
        kNkMAIDCameraType_D4S = 57,      // D4S
        kNkMAIDCameraType_D810 = 58,     // D810
        kNkMAIDCameraType_D750 = 59      // D750
    }

    public enum eNkMAIDCapability : int
    {
        kNkMAIDCapability_AsyncRate = 1,                           // milliseconds between idle async calls
        kNkMAIDCapability_ProgressProc = 2,                        // callback during lengthy operation
        kNkMAIDCapability_EventProc = 3,                           // callback when event occurs
        kNkMAIDCapability_DataProc = 4,                            // callback to deliver data
        kNkMAIDCapability_UIRequestProc = 5,                       // callback to show user interface
        kNkMAIDCapability_IsAlive = 6,                             // FALSE if object is removed or parent closed
        kNkMAIDCapability_Children = 7,                            // IDs of children objects
        kNkMAIDCapability_State = 8,                               // current state of the object
        kNkMAIDCapability_Name = 9,                                // a string representing the name of the object
        kNkMAIDCapability_Description = 10,                        // a string describing the object
        kNkMAIDCapability_Interface = 11,                          // a string describing the interface to a device
        kNkMAIDCapability_DataTypes = 12,                          // what data types are supported or available
        kNkMAIDCapability_DateTime = 13,                           // date associated with an object
        kNkMAIDCapability_StoredBytes = 14,                        // read only size of object as stored on device
        kNkMAIDCapability_Eject = 15,                              // ejects media from a device
        kNkMAIDCapability_Feed = 16,                               // feeds media into a device
        kNkMAIDCapability_Capture = 17,                            // captures new item from the source
        kNkMAIDCapability_MediaPresent = 18,                       // TRUE if item has physical media to acquire
        kNkMAIDCapability_Mode = 19,                               // mode of this object
        kNkMAIDCapability_Acquire = 20,                            // begins the acquisition of the object
        kNkMAIDCapability_ForceScan = 21,                          // If FALSE, unneccesary scans can be eliminated
        kNkMAIDCapability_Start = 22,                              // start offset (in seconds) of the object
        kNkMAIDCapability_Length = 23,                             // length (in seconds) of the object
        kNkMAIDCapability_SampleRate = 24,                         // sampling rate (in samples/sec) of the object
        kNkMAIDCapability_Stereo = 25,                             // mono or stereo
        kNkMAIDCapability_Samples = 26,                            // given current state, read only number of samples
        kNkMAIDCapability_Filter = 27,                             // selects the filter for the light source
        kNkMAIDCapability_Prescan = 28,                            // sets the focus automatically
        kNkMAIDCapability_ForcePrescan = 29,                       // If FALSE, unneccesary prescans can be eliminated
        kNkMAIDCapability_AutoFocus = 30,                          // sets the focus automatically
        kNkMAIDCapability_ForceAutoFocus = 31,                     // If FALSE, unneccesary autofocus can be eliminated
        kNkMAIDCapability_AutoFocusPt = 32,                        // sets the position to focus upon
        kNkMAIDCapability_Focus = 33,                              // sets the focus
        kNkMAIDCapability_Coords = 34,                             // rectangle of object in device units
        kNkMAIDCapability_Resolution = 35,                         // resolution of object (in pixels/inch)
        kNkMAIDCapability_Preview = 36,                            // preview or final acquire
        kNkMAIDCapability_Negative = 37,                           // negative or positive original
        kNkMAIDCapability_ColorSpace = 38,                         // color space
        kNkMAIDCapability_Bits = 39,                               // bits per color
        kNkMAIDCapability_Planar = 40,                             // interleaved or planar data transfer
        kNkMAIDCapability_Lut = 41,                                // LUT(s) for object
        kNkMAIDCapability_Transparency = 42,                       // light path of the original
        kNkMAIDCapability_Threshold = 43,                          // threshold level for lineart images
        kNkMAIDCapability_Pixels = 44,                             // given current state, read only size of image
        kNkMAIDCapability_NegativeDefault = 45,                    // Default value for Negative capbility
        kNkMAIDCapability_Firmware = 46,                           // Firmware version
        kNkMAIDCapability_CommunicationLevel1 = 47,                // Device communication method (level 1)
        kNkMAIDCapability_CommunicationLevel2 = 48,                // Device communication method (level 2)
        kNkMAIDCapability_BatteryLevel = 49,                       // Device battery level
        kNkMAIDCapability_FreeBytes = 50,                          // Free bytes in device storage
        kNkMAIDCapability_FreeItems = 51,                          // Free items in device storage
        kNkMAIDCapability_Remove = 52,                             // Remove an object from device storage
        kNkMAIDCapability_FlashMode = 53,                          // Device flash (speedlight) mode
        kNkMAIDCapability_ModuleType = 54,                         // Module type
        kNkMAIDCapability_AcquireStreamStart = 55,                 // Starts a stream acquire
        kNkMAIDCapability_AcquireStreamStop = 56,                  // Stops a stream acquire
        kNkMAIDCapability_AcceptDiskAcquisition = 57,              // Sets parameters for disk acquisition
        kNkMAIDCapability_Version = 58,                            // MAID version
        kNkMAIDCapability_FilmFormat = 59,                         // File Size (35mm, 6*6 etc...)
        kNkMAIDCapability_TotalBytes = 60,                         // Number of bytes in device storage
        kNkMAIDCapability_VendorBase = 32768,                      // vendor supplied capabilities start here
        kNkMAIDCapability_InterpolationMethod = 32769,             // Not in use from LS4000
        kNkMAIDCapability_Sharpness = 32770,                       // Not in use from
        kNkMAIDCapability_NegativePrescanMode = 32771,             // Not in use from LS4000
        kNkMAIDCapability_IntegratedPreview = 32774,               // From LS4000
        kNkMAIDCapability_Monochrome = 32775,                      // From LS4000
        kNkMAIDCapability_MonochromeDefault = 32776,               // From LS4000
        kNkMAIDCapability_Kodachrome = 32780,                      // From LS4000
        kNkMAIDCapability_KodachromeDefault = 32781,               // From LS4000
        kNkMAIDCapability_SDCGroup = 32784,                        // kNkMAIDCapability_SDCOn= kNkMAIDCapability_VendorBase + 0x11,
        kNkMAIDCapability_SDCMode = 32786,
        kNkMAIDCapability_SDCDefect = 32787,                       // Not in use from LS4000
        kNkMAIDCapability_SDCPreview = 32788,
        kNkMAIDCapability_SDCHelp = 32789,
        kNkMAIDCapability_ROCGEMEnable = 32794,                    // From LS4000
        kNkMAIDCapability_ROCGEMArea = 32795,                      // From LS4000
        kNkMAIDCapability_ROCGEMAreaBase = 32796,                  // From LS4000
        kNkMAIDCapability_ROCGEMMode = 32797,                      // From LS4000
        kNkMAIDCapability_CMLGroup = 32800,
        kNkMAIDCapability_CMLMode = 32801,
        kNkMAIDCapability_CMLInputProfile = 32802,
        kNkMAIDCapability_CMLOutputProfile = 32803,
        kNkMAIDCapability_AutoFeeder = 32817,
        kNkMAIDCapability_DefaultOrientation = 32818,
        kNkMAIDCapability_FocusGroup = 32821,
        kNkMAIDCapability_FocusMove = 32822,
        kNkMAIDCapability_FocusHelp = 32823,
        kNkMAIDCapability_SelfAutoFocus = 32826,                   // From LS4000
        kNkMAIDCapability_SelfAutoFocusHelp = 32827,               // From LS8000
        kNkMAIDCapability_SelfAutoFocusGroup = 32828,              // From LS8000
        kNkMAIDCapability_AnalogGainMaster = 32848,
        kNkMAIDCapability_AnalogGainRed = 32849,
        kNkMAIDCapability_AnalogGainGreen = 32850,
        kNkMAIDCapability_AnalogGainBlue = 32851,
        kNkMAIDCapability_AnalogGainGray = 32852,
        kNkMAIDCapability_AnalogGainHelp = 32853,
        kNkMAIDCapability_AnalogGainGroup = 32854,
        kNkMAIDCapability_BaseGainRed = 32855,
        kNkMAIDCapability_BaseGainGreen = 32856,
        kNkMAIDCapability_BaseGainBlue = 32857,
        kNkMAIDCapability_BaseGainGray = 32858,
        kNkMAIDCapability_QualityModeNew = 32880,
        kNkMAIDCapability_QualityModeHelp = 32881,
        kNkMAIDCapability_QualityModeGroup = 32882,
        kNkMAIDCapability_BoundaryOffset = 32885,
        kNkMAIDCapability_ReloadThumbnail = 32886,
        kNkMAIDCapability_BoundaryGroup = 32887,
        kNkMAIDCapability_AdvancedMode = 32888,
        kNkMAIDCapability_ClearTimer = 32889,
        kNkMAIDCapability_FeedVendor = 32890,
        kNkMAIDCapability_SDCThreshold = 32892,                    // Not in use from LS4000
        kNkMAIDCapability_SDCMearge = 32893,                       // Not in use from LS4000
        kNkMAIDCapability_IrProcess = 32894,
        kNkMAIDCapability_OutputBits = 32895,
        kNkMAIDCapability_ExposureOnly = 32896,
        kNkMAIDCapability_SetupShading = 32897,
        kNkMAIDCapability_Selected = 32898,
        kNkMAIDCapability_ResetPrescan = 32899,
        kNkMAIDCapability_MaximumChildren = 32900,                 // From Nikon Scan 3.0
        kNkMAIDCapability_DriveMode = 32901,                       // For LS-8000
        kNkMAIDCapability_DriveModeHelp = 32902,                   // For LS-8000
        kNkMAIDCapability_DriveModeGroup = 32903,                  // For LS-8000
        kNkMAIDCapability_AdaptorID = 32904,                       // For LS-8000
        kNkMAIDCapability_ReverseState = 32905,                    // For LS-4000
        kNkMAIDCapability_NegativeScanMode = 32906,                // From Nikon Scan 3.1.1
        kNkMAIDCapability_ExtrasHelp = 32912,
        kNkMAIDCapability_DurationTime = 32928,
        kNkMAIDCapability_DurationTimeHelp = 32929,
        kNkMAIDCapability_DurationTimeGroup = 32930,
        kNkMAIDCapability_RevelationEnable = 32931,                // For LS-5000
        kNkMAIDCapability_NikonEnhancementEnable = 32932,          // For LS-5000 add sugiyama 2003/02/20
        kNkMAIDCapability_NikonEnhancementGroup = 32933,           // For LS-5000
        kNkMAIDCapability_NikonEnhancementHelp = 32934,            // For LS-5000
        kNkMAIDCapability_NikonEnhancementMode = 32935,            // For LS-5000
        kNkMAIDCapability_EVInterval = 33024,
        kNkMAIDCapability_ModuleMode = 33025,                      // 0x8101
        kNkMAIDCapability_CurrentDirectory = 33026,
        kNkMAIDCapability_FormatStorage = 33027,
        kNkMAIDCapability_PreCapture = 33028,
        kNkMAIDCapability_LockFocus = 33029,
        kNkMAIDCapability_LockExposure = 33030,
        kNkMAIDCapability_LifeTime = 33031,
        kNkMAIDCapability_CFStatus = 33032,
        kNkMAIDCapability_ClockBatteryLevel = 33033,
        kNkMAIDCapability_FlashStatus = 33034,
        kNkMAIDCapability_ExposureStatus = 33035,
        kNkMAIDCapability_MediaType = 33036,
        kNkMAIDCapability_FileType = 33039,
        kNkMAIDCapability_CompressionLevel = 33040,
        kNkMAIDCapability_ExposureMode = 33041,
        kNkMAIDCapability_ShutterSpeed = 33042,
        kNkMAIDCapability_Aperture = 33043,
        kNkMAIDCapability_FlexibleProgram = 33044,
        kNkMAIDCapability_ExposureComp = 33045,
        kNkMAIDCapability_MeteringMode = 33046,
        kNkMAIDCapability_Sensitivity = 33047,
        kNkMAIDCapability_WBMode = 33048,
        kNkMAIDCapability_WBTuneAuto = 33049,
        kNkMAIDCapability_WBTuneIncandescent = 33050,
        kNkMAIDCapability_WBTuneFluorescent = 33051,
        kNkMAIDCapability_WBTuneSunny = 33052,
        kNkMAIDCapability_WBTuneFlash = 33053,
        kNkMAIDCapability_WBTuneShade = 33054,
        kNkMAIDCapability_WBTuneCloudy = 33055,
        kNkMAIDCapability_FocusMode = 33056,
        kNkMAIDCapability_FocusAreaMode = 33057,
        kNkMAIDCapability_FocusPreferredArea = 33058,
        kNkMAIDCapability_FocalLength = 33059,
        kNkMAIDCapability_ClockDateTime = 33060,
        kNkMAIDCapability_CustomSettings = 33061,
        kNkMAIDCapability_BracketingOrder = 33062,
        kNkMAIDCapability_BracketingVary = 33063,
        kNkMAIDCapability_AFonRelease = 33064,
        kNkMAIDCapability_AFAreaSelector = 33065,
        kNkMAIDCapability_AFsPriority = 33066,
        kNkMAIDCapability_AFcPriority = 33067,
        kNkMAIDCapability_DeleteDirectory = 33068,
        kNkMAIDCapability_CWMeteringDiameter = 33069,
        kNkMAIDCapability_AELockonRelease = 33070,
        kNkMAIDCapability_ExchangeDials = 33071,
        kNkMAIDCapability_EasyExposureComp = 33072,
        kNkMAIDCapability_Microscope = 33073,
        kNkMAIDCapability_AutoOffDelay = 33074,
        kNkMAIDCapability_SelfTimerDuration = 33075,
        kNkMAIDCapability_LCDBackLight = 33076,
        kNkMAIDCapability_PlayBackImage = 33077,
        kNkMAIDCapability_LimitImageDisplay = 33078,
        kNkMAIDCapability_BlinkTimerLED = 33079,
        kNkMAIDCapability_ApertureDial = 33080,
        kNkMAIDCapability_ZoomAperture = 33081,
        kNkMAIDCapability_AEAFLockButton = 33082,
        kNkMAIDCapability_EdgeEnhancement = 33083,
        kNkMAIDCapability_Curve = 33084,
        kNkMAIDCapability_ShootingSpeed = 33085,
        kNkMAIDCapability_ShootingLimit = 33086,
        kNkMAIDCapability_LutHeader = 33087,
        kNkMAIDCapability_FileHeader = 33088,
        kNkMAIDCapability_LockCamera = 33089,
        kNkMAIDCapability_LockShutterSpeed = 33090,
        kNkMAIDCapability_LockAperture = 33091,
        kNkMAIDCapability_LensInfo = 33092,
        kNkMAIDCapability_MirrorUp = 33093,
        kNkMAIDCapability_EnableNIF = 33094,
        kNkMAIDCapability_PlaybackMode = 33095,
        kNkMAIDCapability_UserComment = 33096,
        kNkMAIDCapability_NumberingMode = 33097,
        kNkMAIDCapability_ReadOnly = 33098,
        kNkMAIDCapability_Invisible = 33099,
        kNkMAIDCapability_DirCreatedByDx2 = 33100,
        kNkMAIDCapability_DirCreatedByD1 = 33100,
        kNkMAIDCapability_ContinuousInPCMode = 33101,
        kNkMAIDCapability_CurrentDirID = 33102,
        kNkMAIDCapability_SensitivityIncrease = 33103,
        kNkMAIDCapability_WritingMedia = 33104,
        kNkMAIDCapability_WBPresetNumber = 33105,
        kNkMAIDCapability_ThumbnailSize = 33106,
        kNkMAIDCapability_SensitivityInterval = 33107,
        kNkMAIDCapability_ShootNoCard = 33108,
        kNkMAIDCapability_ColorReproduct = 33110,
        kNkMAIDCapability_ImageSize = 33111,
        kNkMAIDCapability_CompressRAW = 33112,
        kNkMAIDCapability_EnableMonitor = 33113,
        kNkMAIDCapability_WBGainRed = 33114,
        kNkMAIDCapability_WBGainBlue = 33115,
        kNkMAIDCapability_MakeDirectory = 33116,
        kNkMAIDCapability_RearPanelDisplayMode = 33117,
        kNkMAIDCapability_ColorAdjustment = 33118,
        kNkMAIDCapability_SelectFUNC = 33119,
        kNkMAIDCapability_TypicalFlashMode = 33120,
        kNkMAIDCapability_Converter = 33121,
        kNkMAIDCapability_ElectronicZoom = 33122,
        kNkMAIDCapability_DateFormat = 33123,
        kNkMAIDCapability_PreviewInterval = 33124,
        kNkMAIDCapability_MenuBank = 33125,
        kNkMAIDCapability_FlashComp = 33126,
        kNkMAIDCapability_NoAperture = 33127,
        kNkMAIDCapability_AntiVibration = 33128,
        kNkMAIDCapability_BatteryPack = 33129,
        kNkMAIDCapability_ResetCustomSetting = 33130,
        kNkMAIDCapability_ImagePreview = 33131,
        kNkMAIDCapability_IsoControl = 33132,
        kNkMAIDCapability_NoiseReduction = 33133,
        kNkMAIDCapability_FocusAreaLed = 33134,
        kNkMAIDCapability_AfSubLight = 33135,
        kNkMAIDCapability_AfButton = 33136,
        kNkMAIDCapability_SoundLevel = 33137,
        kNkMAIDCapability_FinderMode = 33138,
        kNkMAIDCapability_AeBracketNum = 33139,
        kNkMAIDCapability_WbBracketNum = 33140,
        kNkMAIDCapability_InternalSplMode = 33141,
        kNkMAIDCapability_EnableComment = 33142,
        kNkMAIDCapability_PresetExpMode = 33143,
        kNkMAIDCapability_PossibleToShoot = 33144,
        kNkMAIDCapability_ResetFileNumber = 33145,
        kNkMAIDCapability_ExpCompInterval = 33152,
        kNkMAIDCapability_FocusGroupPreferredArea = 33162,
        kNkMAIDCapability_ResetMenuBank = 33163,
        kNkMAIDCapability_WBTuneColorTemp = 33164,
        kNkMAIDCapability_ShootingMode = 33165,
        kNkMAIDCapability_LockFV = 33166,
        kNkMAIDCapability_RemainContinuousShooting = 33167,
        kNkMAIDCapability_ShootingBankName = 33168,
        kNkMAIDCapability_WBPresetName = 33169,
        kNkMAIDCapability_FmmManual = 33170,
        kNkMAIDCapability_F0Manual = 33171,
        kNkMAIDCapability_CustomBankName = 33172,
        kNkMAIDCapability_AfGroupAreaPattern = 33173,
        kNkMAIDCapability_FocusFrameInMf = 33174,
        kNkMAIDCapability_FocusFrameInContinuousShooting = 33175,
        kNkMAIDCapability_FocusFrameDisplayTime = 33176,
        kNkMAIDCapability_ExposureDelay = 33177,
        kNkMAIDCapability_AddIccProfile = 33178,
        kNkMAIDCapability_ShootCounterInFinder = 33179,
        kNkMAIDCapability_CenterButtonOnShooting = 33180,
        kNkMAIDCapability_CenterButtonOnPlayback = 33181,
        kNkMAIDCapability_MultiSelector = 33182,
        kNkMAIDCapability_MultiSelectorDirection = 33183,
        kNkMAIDCapability_CommandDialDirection = 33184,
        kNkMAIDCapability_EnableCommandDialOnPlayback = 33185,
        kNkMAIDCapability_UniversalMode = 33186,
        kNkMAIDCapability_VerticalAfButton = 33188,
        kNkMAIDCapability_FlashSyncTime = 33189,
        kNkMAIDCapability_FlashSlowLimit = 33190,
        kNkMAIDCapability_ExternalFlashMode = 33191,
        kNkMAIDCapability_ModelingOnPreviewButton = 33192,
        kNkMAIDCapability_BracketingFactor = 33193,
        kNkMAIDCapability_BracketingMethod = 33194,
        kNkMAIDCapability_RGBGain = 33195,
        kNkMAIDCapability_USBSpeed = 33196,
        kNkMAIDCapability_WBPresetData = 33197,
        kNkMAIDCapability_ContinuousShootingNum = 33198,
        kNkMAIDCapability_EnableBracketing = 33199,
        kNkMAIDCapability_BracketingType = 33200,
        kNkMAIDCapability_AEBracketingStep = 33201,
        kNkMAIDCapability_WBBracketingStep = 33202,
        kNkMAIDCapability_BracketingCount = 33203,
        kNkMAIDCapability_CameraInclination = 33204,
        kNkMAIDCapability_RawJpegImageStatus = 33205,
        kNkMAIDCapability_CaptureDustImage = 33206,
        kNkMAIDCapability_ZoomRateOnPlayback = 33207,
        kNkMAIDCapability_AfGroupAreaPatternType = 33208,
        kNkMAIDCapability_ExternalFlashSort = 33209,
        kNkMAIDCapability_ExternalOldTypeFlashMode = 33210,
        kNkMAIDCapability_ExternalNewTypeFlashMode = 33211,
        kNkMAIDCapability_InternalFlashStatus = 33212,
        kNkMAIDCapability_ExternalFlashStatus = 33213,
        kNkMAIDCapability_InternalFlashComp = 33214,
        kNkMAIDCapability_ExternalFlashComp = 33215,
        kNkMAIDCapability_ImageSetting = 33216,
        kNkMAIDCapability_SaturationSetting = 33217,
        kNkMAIDCapability_Beep = 33218,
        kNkMAIDCapability_AFMode = 33219,
        kNkMAIDCapability_ISOAutoShutterTime = 33220,
        kNkMAIDCapability_InternalSplValue = 33221,
        kNkMAIDCapability_InternalSplCommand = 33222,
        kNkMAIDCapability_RecommendFlashDisp = 33223,
        kNkMAIDCapability_RemoteTimer = 33224,
        kNkMAIDCapability_CameraInclinationMode = 33225,
        kNkMAIDCapability_InternalSplCommandValue = 33227,
        kNkMAIDCapability_PreviewStatus = 33228,
        kNkMAIDCapability_PreviewImage = 33229,
        kNkMAIDCapability_CCDDataMode = 33232,
        kNkMAIDCapability_JpegCompressionPolicy = 33233,
        kNkMAIDCapability_AFLockOn = 33234,
        kNkMAIDCapability_FocalLengthControl = 33235,
        kNkMAIDCapability_ExpBaseMatrix = 33236,
        kNkMAIDCapability_ExpBaseCenter = 33237,
        kNkMAIDCapability_ExpBaseSpot = 33238,
        kNkMAIDCapability_CameraType = 33239,
        kNkMAIDCapability_NoiseReductionHighISO = 33240,
        kNkMAIDCapability_EasyExposureCompMode = 33241,
        kNkMAIDCapability_DeviceNameList = 33242,
        kNkMAIDCapability_ImageColorSpace = 33243,
        kNkMAIDCapability_ISOAutoSetting = 33244,
        kNkMAIDCapability_ImageMode = 33245,
        kNkMAIDCapability_FocusAreaFrame = 33265,
        kNkMAIDCapability_ISOAutoHiLimit = 33266,
        kNkMAIDCapability_BeepEx = 33267,
        kNkMAIDCapability_AFLockOnEx = 33268,
        kNkMAIDCapability_WarningDisp = 33269,
        kNkMAIDCapability_CellKind = 33270,
        kNkMAIDCapability_InternalSplMRPTValue = 33271,
        kNkMAIDCapability_InternalSplMRPTCount = 33272,
        kNkMAIDCapability_InternalSplMRPTInterval = 33273,
        kNkMAIDCapability_InternalSplCommandChannel = 33274,
        kNkMAIDCapability_InternalSplCmdSelfComp = 33275,
        kNkMAIDCapability_InternalSplCmdGroupAMode = 33276,
        kNkMAIDCapability_InternalSplCmdGroupAComp = 33277,
        kNkMAIDCapability_InternalSplCmdGroupAValue = 33278,
        kNkMAIDCapability_InternalSplCmdGroupBMode = 33279,
        kNkMAIDCapability_InternalSplCmdGroupBComp = 33280,
        kNkMAIDCapability_InternalSplCmdGroupBValue = 33281,
        kNkMAIDCapability_InternalSplCmdSelfMode = 33282,
        kNkMAIDCapability_InternalSplCmdSelfValue = 33283,
        kNkMAIDCapability_SelectFUNC2 = 33284,
        kNkMAIDCapability_LutIndexNumber = 33285,
        kNkMAIDCapability_MonochromeFilterEffect = 33312,
        kNkMAIDCapability_MonochromeEdgeEnhancement = 33313,
        kNkMAIDCapability_MonochromeCurve = 33314,
        kNkMAIDCapability_AutoFPShoot = 33315,
        kNkMAIDCapability_MonochromeSettingType = 33316,
        kNkMAIDCapability_AFCapture = 33317,
        kNkMAIDCapability_AutoOffTimer = 33318,
        kNkMAIDCapability_ImageConfirmTime = 33319,
        kNkMAIDCapability_InfoDisplayErrStatus = 33320,
        kNkMAIDCapability_ExternalSplMode = 33321,
        kNkMAIDCapability_ExternalSplValue = 33322,
        kNkMAIDCapability_Slot2ImageSaveMode = 33324,
        kNkMAIDCapability_CompressRAWBitMode = 33325,
        kNkMAIDCapability_PictureControl = 33326,
        kNkMAIDCapability_IntegratedLevel = 33327,
        kNkMAIDCapability_Brightness = 33328,
        kNkMAIDCapability_MonochromeTuneColors = 33329,
        kNkMAIDCapability_Active_D_Lighting = 33330,
        kNkMAIDCapability_DynamicAFArea = 33331,
        kNkMAIDCapability_ShootingSpeedHigh = 33332,
        kNkMAIDCapability_InfoDispSetting = 33333,
        kNkMAIDCapability_PreviewButton = 33335,
        kNkMAIDCapability_PreviewButton2 = 33336,
        kNkMAIDCapability_AEAFLockButton2 = 33338,
        kNkMAIDCapability_IndicatorDisplay = 33339,
        kNkMAIDCapability_LiveViewMode = 33340,
        kNkMAIDCapability_LiveViewDriveMode = 33341,
        kNkMAIDCapability_LiveViewStatus = 33342,
        kNkMAIDCapability_LiveViewImageZoomRate = 33343,
        kNkMAIDCapability_ContrastAF = 33344,
        kNkMAIDCapability_DeleteDramImage = 33347,
        kNkMAIDCapability_CurrentPreviewID = 33348,
        kNkMAIDCapability_GetPreviewImageLow = 33349,
        kNkMAIDCapability_GetPreviewImageNormal = 33350,
        kNkMAIDCapability_GetLiveViewImage = 33351,
        kNkMAIDCapability_MFDriveStep = 33352,
        kNkMAIDCapability_MFDrive = 33353,
        kNkMAIDCapability_ContrastAFArea = 33354,
        kNkMAIDCapability_CompressRAWEx = 33355,
        kNkMAIDCapability_CellKindPriority = 33356,
        kNkMAIDCapability_WBFluorescentType = 33357,
        kNkMAIDCapability_WBTuneColorAdjust = 33358,
        kNkMAIDCapability_WBTunePreset1 = 33359,
        kNkMAIDCapability_WBTunePreset2 = 33360,
        kNkMAIDCapability_WBTunePreset3 = 33361,
        kNkMAIDCapability_WBTunePreset4 = 33362,
        kNkMAIDCapability_WBTunePreset5 = 33363,
        kNkMAIDCapability_AFAreaPoint = 33364,
        kNkMAIDCapability_NormalAfButton = 33365,
        kNkMAIDCapability_ManualSetLensNo = 33366,
        kNkMAIDCapability_AutoDXCrop = 33367,
        kNkMAIDCapability_PictureControlData = 33368,
        kNkMAIDCapability_GetPicCtrlInfo = 33369,
        kNkMAIDCapability_DeleteCustomPictureControl = 33370,
        kNkMAIDCapability_LensType = 33372,
        kNkMAIDCapability_ChangedPictureControl = 33373,
        kNkMAIDCapability_LiveViewProhibit = 33374,
        kNkMAIDCapability_DateImprintSetting = 33375,
        kNkMAIDCapability_DateCounterSelect = 33376,
        kNkMAIDCapability_DateCounterData = 33377,
        kNkMAIDCapability_DateCounterDispSetting = 33378,
        kNkMAIDCapability_RangeFinderSetting = 33379,
        kNkMAIDCapability_RangeFinderStatus = 33380,
        kNkMAIDCapability_AutoOffPhoto = 33381,
        kNkMAIDCapability_AutoOffMenu = 33382,
        kNkMAIDCapability_AutoOffInfo = 33383,
        kNkMAIDCapability_ScreenTips = 33384,
        kNkMAIDCapability_IlluminationSetting = 33385,
        kNkMAIDCapability_ShutterSpeedLockSetting = 33386,
        kNkMAIDCapability_ApertureLockSetting = 33387,
        kNkMAIDCapability_VignetteControl = 33388,
        kNkMAIDCapability_FocusPointBrightness = 33389,
        kNkMAIDCapability_EnableCopyright = 33390,
        kNkMAIDCapability_ArtistName = 33391,
        kNkMAIDCapability_CopyrightInfo = 33392,
        kNkMAIDCapability_AngleLevel = 33393,
        kNkMAIDCapability_MovieScreenSize = 33394,
        kNkMAIDCapability_MovieVoice = 33395,
        kNkMAIDCapability_LiveViewAF = 33397,
        kNkMAIDCapability_SelfTimerShootNum = 33398,
        kNkMAIDCapability_FinderISODisplay = 33399,
        kNkMAIDCapability_EnableCommandDialOnPlaybackEx = 33400,
        kNkMAIDCapability_ExchangeDialsEx = 33401,
        kNkMAIDCapability_CenterButtonOnLiveView = 33408,
        kNkMAIDCapability_ZoomRateOnLiveView = 33409,
        kNkMAIDCapability_AutoDistortion = 33410,
        kNkMAIDCapability_SceneMode = 33411,
        kNkMAIDCapability_LiveViewScreenDispSetting = 33412,
        kNkMAIDCapability_MovieRecMicrophone = 33413,
        kNkMAIDCapability_MovieRecDestination = 33414,
        kNkMAIDCapability_PrimarySlot = 33415,
        kNkMAIDCapability_ADLBracketingType = 33416,
        kNkMAIDCapability_SelectFUNC2CapAreaCrop = 33425,
        kNkMAIDCapability_PreviewButton2CapAreaCrop = 33426,
        kNkMAIDCapability_AEAFLockButton2CapAreaCrop = 33427,
        kNkMAIDCapability_BracketButton = 33428,
        kNkMAIDCapability_RemainCountInMedia = 33429,
        kNkMAIDCapability_AngleLevelPitch = 33430,
        kNkMAIDCapability_AngleLevelYaw = 33431,
        kNkMAIDCapability_MovRecInCardStatus = 33432,
        kNkMAIDCapability_MovRecInCardProhibit = 33433,
        kNkMAIDCapability_ActiveSlot = 33540,
        kNkMAIDCapability_SaveMedia = 33541,
        kNkMAIDCapability_MovieRecHiISO = 33542,
        kNkMAIDCapability_UserMode1 = 33543,
        kNkMAIDCapability_UserMode2 = 33544,
        kNkMAIDCapability_MovieManualSetting = 33545,
        kNkMAIDCapability_AFModeAtLiveView = 33552,
        kNkMAIDCapability_SelfTimerShootInterval = 33553,
        kNkMAIDCapability_AutoOffLiveView = 33554,
        kNkMAIDCapability_RemoteCtrlWaitTime = 33555,
        kNkMAIDCapability_BeepVolume = 33556,
        kNkMAIDCapability_VideoMode = 33557,
        kNkMAIDCapability_WBAutoType = 33558,
        kNkMAIDCapability_GetVideoImage = 33559,
        kNkMAIDCapability_TerminateCapture = 33560,
        kNkMAIDCapability_EffectMode = 33561,
        kNkMAIDCapability_HDRMode = 33568,
        kNkMAIDCapability_HDRExposure = 33569,
        kNkMAIDCapability_HDRSmoothing = 33570,
        kNkMAIDCapability_BlinkingStatus = 33571,
        kNkMAIDCapability_AutoSceneModeStatus = 33572,
        kNkMAIDCapability_WBTuneColorTempEx = 33573,
        kNkMAIDCapability_WBPresetProtect1 = 33574,
        kNkMAIDCapability_WBPresetProtect2 = 33575,
        kNkMAIDCapability_WBPresetProtect3 = 33576,
        kNkMAIDCapability_WBPresetProtect4 = 33577,
        kNkMAIDCapability_ISOAutoShutterTimeAutoValue = 33584,
        kNkMAIDCapability_MovieImageQuality = 33585,
        kNkMAIDCapability_MovieRecMicrophoneValue = 33586,
        kNkMAIDCapability_LiveViewExposurePreview = 33587,
        kNkMAIDCapability_LiveViewSelector = 33588,
        kNkMAIDCapability_LiveViewWBMode = 33589,
        kNkMAIDCapability_MovieShutterSpeed = 33590,
        kNkMAIDCapability_MovieAperture = 33591,
        kNkMAIDCapability_MovieSensitivity = 33592,
        kNkMAIDCapability_MovieExposureComp = 33593,
        kNkMAIDCapability_ADLBracketingStep = 33603,
        kNkMAIDCapability_ResetWBMode = 33604,
        kNkMAIDCapability_ExpCompFlashUsed = 33605,
        kNkMAIDCapability_LiveViewPhotoShootingMode = 33606,
        kNkMAIDCapability_ExposureDelayEx = 33607,
        kNkMAIDCapability_MovieISORange = 33608,
        kNkMAIDCapability_MovieReleaseButton = 33609,
        kNkMAIDCapability_MovieRecFrameCount = 33616,
        kNkMAIDCapability_CurrentItemID = 33617,
        kNkMAIDCapability_GetIPTCInfo = 33618,
        kNkMAIDCapability_LiveViewImageSize = 33619,
        kNkMAIDCapability_RemoteControlMode = 33620,
        kNkMAIDCapability_WBTunePreset6 = 33621,
        kNkMAIDCapability_WBPresetProtect5 = 33622,
        kNkMAIDCapability_WBPresetProtect6 = 33623,
        kNkMAIDCapability_SpotWBMode = 33624,
        kNkMAIDCapability_SpotWBMeasure = 33625,
        kNkMAIDCapability_SpotWBChangeArea = 33632,
        kNkMAIDCapability_SpotWBResultDispEnd = 33633,
        kNkMAIDCapability_MovieWindNoiseReduction = 33824,
        kNkMAIDCapability_RetractableLensWarningStatus = 33825,
        kNkMAIDCapability_ISOControlSensitivity = 33826,
        kNkMAIDCapability_ExposureMeterLinkage = 33840,
        kNkMAIDCapability_MovieRecordingZone = 33872,
        kNkMAIDCapability_MovieISOControl = 33873,
        kNkMAIDCapability_MovieISOAutoHiLimit = 33874,
        kNkMAIDCapability_RawImageSize = 33875,
        kNkMAIDCapability_RawJpegTransferStatus = 33876,
        kNkMAIDCapability_LimitAFAreaMode = 33877,
        kNkMAIDCapability_AFModeRestrictions = 33878,
        kNkMAIDCapability_ExpBaseHighlight = 33879,
        kNkMAIDCapability_ElectronicFrontCurtainShutter = 33880,
        kNkMAIDCapability_PictureControlDataEx = 33881,
        kNkMAIDCapability_MovieWBMode = 33888,
        kNkMAIDCapability_MovieWBTuneAuto = 33889,
        kNkMAIDCapability_MovieWBAutoType = 33890,
        kNkMAIDCapability_MovieWBTuneIncandescent = 33891,
        kNkMAIDCapability_MovieWBFluorescentType = 33892,
        kNkMAIDCapability_MovieWBTuneFluorescent = 33893,
        kNkMAIDCapability_MovieWBTuneSunny = 33894,
        kNkMAIDCapability_MovieWBTuneShade = 33896,
        kNkMAIDCapability_MovieWBTuneCloudy = 33897,
        kNkMAIDCapability_MovieWBTuneColorTempEx = 33898,
        kNkMAIDCapability_MovieWBTuneColorAdjust = 33899,
        kNkMAIDCapability_MovieWBTunePreset1 = 33900,
        kNkMAIDCapability_MovieWBTunePreset2 = 33901,
        kNkMAIDCapability_MovieWBTunePreset3 = 33902,
        kNkMAIDCapability_MovieWBTunePreset4 = 33903,
        kNkMAIDCapability_MovieWBTunePreset5 = 33904,
        kNkMAIDCapability_MovieWBTunePreset6 = 33905,
        kNkMAIDCapability_MovieWBPresetProtect1 = 33906,
        kNkMAIDCapability_MovieWBPresetProtect2 = 33907,
        kNkMAIDCapability_MovieWBPresetProtect3 = 33908,
        kNkMAIDCapability_MovieWBPresetProtect4 = 33909,
        kNkMAIDCapability_MovieWBPresetProtect5 = 33910,
        kNkMAIDCapability_MovieWBPresetProtect6 = 33911,
        kNkMAIDCapability_MovieWBPresetNumber = 33912,
        kNkMAIDCapability_MovieWBPresetName = 33913,
        kNkMAIDCapability_MovieWBGainRed = 33914,
        kNkMAIDCapability_MovieWBGainBlue = 33915,
        kNkMAIDCapability_MoviePictureControlData = 33916,
        kNkMAIDCapability_MoviePictureControlDataEx = 33917,
        kNkMAIDCapability_MovieResetMenuBank = 33918,
        kNkMAIDCapability_MovieCCDDataMode = 33919,
        kNkMAIDCapability_MovieAutoDXCrop = 33920,
        kNkMAIDCapability_MovieNoiseReductionHighISO = 33921,
        kNkMAIDCapability_MoviePictureControl = 33922,
        kNkMAIDCapability_ChangedMoviePictureControl = 33923,
        kNkMAIDCapability_MovieResetWBMode = 33924,
        kNkMAIDCapability_MovieMeteringMode = 33925,
        kNkMAIDCapability_GetMoviePicCtrlInfo = 33926,
        kNkMAIDCapability_DeleteMovieCustomPictureControl = 33927,
        kNkMAIDCapability_MovieWBPresetData = 33928
    }

    public enum eNkMAIDCapAreaCrop : int
    {
        kNkMAIDCapAreaCrop_FX = 1,
        kNkMAIDCapAreaCrop_DX = 2,
        kNkMAIDCapAreaCrop_54 = 4,
        kNkMAIDCapAreaCrop_12x = 8
    }

    public enum eNkMAIDCapOperation : int
    {
        kNkMAIDCapOperation_Start = 1,
        kNkMAIDCapOperation_Get = 2,
        kNkMAIDCapOperation_Set = 4,
        kNkMAIDCapOperation_GetArray = 8,
        kNkMAIDCapOperation_GetDefault = 16
    }

    public enum eNkMAIDCapType : int
    {
        kNkMAIDCapType_Process = 0,     // a process that can be started
        kNkMAIDCapType_Boolean = 1,     // single byte boolean value
        kNkMAIDCapType_Integer = 2,     // signed 4 byte value
        kNkMAIDCapType_Unsigned = 3,    // unsigned 4 byte value
        kNkMAIDCapType_Float = 4,       // DOUB_P value
        kNkMAIDCapType_Point = 5,       // NkMAIDPoint structure
        kNkMAIDCapType_Size = 6,        // NkMAIDSize structure
        kNkMAIDCapType_Rect = 7,        // NkMAIDRect structure
        kNkMAIDCapType_String = 8,      // NkMAIDString structure
        kNkMAIDCapType_DateTime = 9,    // NkMAIDDateTime structure
        kNkMAIDCapType_Callback = 10,   // NkMAIDCallback structure
        kNkMAIDCapType_Array = 11,      // NkMAIDArray structure
        kNkMAIDCapType_Enum = 12,       // NkMAIDEnum structure
        kNkMAIDCapType_Range = 13,      // NkMAIDRange structure
        kNkMAIDCapType_Generic = 14,    // generic data
        kNkMAIDCapType_BoolDefault = 15 // Reserved
    }

    public enum eNkMAIDCapVisibility : int
    {
        kNkMAIDCapVisibility_Hidden = 1,
        kNkMAIDCapVisibility_Advanced = 2,
        kNkMAIDCapVisibility_Vendor = 4,
        kNkMAIDCapVisibility_Group = 8,
        kNkMAIDCapVisibility_GroupMember = 16,
        kNkMAIDCapVisibility_Invalid = 32
    }

    public enum eNkMAIDCCDDataMode : int
    {
        kNkMAIDCCDDataMode_Full = 0,
        kNkMAIDCCDDataMode_HiSpeedCrop = 1,
        kNkMAIDCCDDataMode_AutoDXCrop = 2,
        kNkMAIDCCDDataMode_FXFormat = 3,
        kNkMAIDCCDDataMode_DXFormat = 4,
        kNkMAIDCCDDataMode_5_4 = 5,
        kNkMAIDCCDDataMode_12x = 6,
        kNkMAIDCCDDataMode_13x = 7
    }

    public enum eNkMAIDCellKind : int
    {
        kNkMAIDCellKind_Alkaline = 0,
        kNkMAIDCellKind_NiMH = 1,
        kNkMAIDCellKind_Lithium = 2,
        kNkMAIDCellKind_NiMn = 3
    }

    public enum eNkMAIDCellKindPriority : int
    {
        kNkMAIDCellKindPriority_MB_D11 = 0,
        kNkMAIDCellKindPriority_MB_D10 = 0,
        kNkMAIDCellKindPriority_Camera = 1
    }

    public enum eNkMAIDCFStatus : int
    {
        kNkMAIDCFStatus_Good = 0,
        kNkMAIDCFStatus_Full = 1,
        kNkMAIDCFStatus_NotFormated = 2,
        kNkMAIDCFStatus_NotExist = 3,
        kNkMAIDCFStatus_NotAvailable = 4
    }

    public enum eNkMAIDColorAdjustment : int
    {
        kNkMAIDColorAdjustment_Minus9 = 0,
        kNkMAIDColorAdjustment_Minus6 = 1,
        kNkMAIDColorAdjustment_Minus3 = 2,
        kNkMAIDColorAdjustment_0 = 3,
        kNkMAIDColorAdjustment_Plus3 = 4,
        kNkMAIDColorAdjustment_Plus6 = 5,
        kNkMAIDColorAdjustment_Plus9 = 6
    }

    public enum eNkMAIDColorSpace : int
    {
        kNkMAIDColorSpace_LineArt = 0,
        kNkMAIDColorSpace_Grey = 1,
        kNkMAIDColorSpace_RGB = 2,
        kNkMAIDColorSpace_sRGB = 3,
        kNkMAIDColorSpace_CMYK = 4,
        kNkMAIDColorSpace_Lab = 5,
        kNkMAIDColorSpace_LCH = 6,
        kNkMAIDColorSpace_AppleRGB = 7,
        kNkMAIDColorSpace_ColorMatchRGB = 8,
        kNkMAIDColorSpace_NTSCRGB = 9,
        kNkMAIDColorSpace_BruceRGB = 10,
        kNkMAIDColorSpace_AdobeRGB = 11,
        kNkMAIDColorSpace_CIERGB = 12,
        kNkMAIDColorSpace_AdobeWideRGB = 13,
        kNkMAIDColorSpace_AppleRGB_Compensated = 14,
        kNkMAIDColorSpace_VendorBase = 32768,        // vendor supplied colorspaces start here
        kNkMAIDColorSpace_RGBD = 32769
    }

    public enum eNkMAIDCommand : int
    {
        kNkMAIDCommand_Async = 0,          // process asynchronous operations
        kNkMAIDCommand_Open = 1,           // opens a child object
        kNkMAIDCommand_Close = 2,          // closes a previously opened object
        kNkMAIDCommand_GetCapCount = 3,    // get number of capabilities of an object
        kNkMAIDCommand_GetCapInfo = 4,     // get capabilities of an object
        kNkMAIDCommand_CapStart = 5,       // starts capability
        kNkMAIDCommand_CapSet = 6,         // set value of capability
        kNkMAIDCommand_CapGet = 7,         // get value of capability
        kNkMAIDCommand_CapGetDefault = 8,  // get default value of capability
        kNkMAIDCommand_CapGetArray = 9,    // get data for array capability
        kNkMAIDCommand_Mark = 10,          // insert mark in the command queue
        kNkMAIDCommand_AbortToMark = 11,   // abort asynchronous commands to mark
        kNkMAIDCommand_Abort = 12,         // abort current asynchronous command
        kNkMAIDCommand_EnumChildren = 13,  // requests �add� events for all child IDs
        kNkMAIDCommand_GetParent = 14,     // gets previously opened parent for object
        kNkMAIDCommand_ResetToDefault = 15 // resets all capabilities to their default value
    }

    public enum eNkMAIDCompressRAWBitMode : int
    {
        kNkMAIDCompressRAWBitMode_12bit = 0,
        kNkMAIDCompressRAWBitMode_14bit = 1
    }

    public enum eNkMAIDCompressRAWEx : int
    {
        kNkMAIDCompressRAWEx_Uncompressed = 0,
        kNkMAIDCompressRAWEx_Compressed = 1,
        kNkMAIDCompressRAWEx_LosslessCompressed = 2
    }

    public enum eNkMAIDContrastAF : int
    {
        kNkMAIDContrastAF_Start = 0,
        kNkMAIDContrastAF_Stop = 1,
        kNkMAIDContrastAF_OK = 16,
        kNkMAIDContrastAF_OutOfFocus = 17,
        kNkMAIDContrastAF_Busy = 18
    }

    public enum eNkMAIDConverter : int
    {
        kNkMAIDConverter_None = 0,
        kNkMAIDConverter_Wide = 1,
        kNkMAIDConverter_FishEye = 2
    }

    public enum eNkMAIDDataObjType : int
    {
        kNkMAIDDataObjType_Image = 1,
        kNkMAIDDataObjType_Sound = 2,
        kNkMAIDDataObjType_Video = 4,
        kNkMAIDDataObjType_Thumbnail = 8,
        kNkMAIDDataObjType_File = 16
    }

    public enum eNkMAIDDataType : int
    {
        kNkMAIDDataType_Null = 0,
        kNkMAIDDataType_Boolean = 1,      // passed by value, set only
        kNkMAIDDataType_Integer = 2,      // signed 32 bit int, passed by value, set only
        kNkMAIDDataType_Unsigned = 3,     // unsigned 32 bit int, passed by value, set only
        kNkMAIDDataType_BooleanPtr = 4,   // pointer to single byte boolean value(s)
        kNkMAIDDataType_IntegerPtr = 5,   // pointer to signed 4 byte value(s)
        kNkMAIDDataType_UnsignedPtr = 6,  // pointer to unsigned 4 byte value(s)
        kNkMAIDDataType_FloatPtr = 7,     // pointer to DOUB_P value(s)
        kNkMAIDDataType_PointPtr = 8,     // pointer to NkMAIDPoint structure(s)
        kNkMAIDDataType_SizePtr = 9,      // pointer to NkMAIDSize structure(s)
        kNkMAIDDataType_RectPtr = 10,     // pointer to NkMAIDRect structure(s)
        kNkMAIDDataType_StringPtr = 11,   // pointer to NkMAIDString structure(s)
        kNkMAIDDataType_DateTimePtr = 12, // pointer to NkMAIDDateTime structure(s)
        kNkMAIDDataType_CallbackPtr = 13, // pointer to NkMAIDCallback structure(s)
        kNkMAIDDataType_RangePtr = 14,    // pointer to NkMAIDRange structure(s)
        kNkMAIDDataType_ArrayPtr = 15,    // pointer to NkMAIDArray structure(s)
        kNkMAIDDataType_EnumPtr = 16,     // pointer to NkMAIDEnum structure(s)
        kNkMAIDDataType_ObjectPtr = 17,   // pointer to NkMAIDObject structure(s)
        kNkMAIDDataType_CapInfoPtr = 18,  // pointer to NkMAIDCapInfo structure(s)
        kNkMAIDDataType_GenericPtr = 19   // pointer to generic data
    }

    public enum eNkMAIDDateCounterDispSetting : int
    {
        kNkMAIDDateCounterDispSetting_NumberOfDays = 0,     // Number of days
        kNkMAIDDateCounterDispSetting_Years_Days = 1,       // Years and days
        kNkMAIDDateCounterDispSetting_Years_Months_Days = 2 // Years, months, and days
    }

    public enum eNkMAIDDateCounterSelect : int
    {
        kNkMAIDDateCounterSelect_1 = 0, // 1st
        kNkMAIDDateCounterSelect_2 = 1, // 2nd
        kNkMAIDDateCounterSelect_3 = 2  // 3rd
    }

    public enum eNkMAIDDateFormat : int
    {
        kNkMAIDDateFormat_Off = 0,
        kNkMAIDDateFormat_YMD = 1,
        kNkMAIDDateFormat_MDY = 2,
        kNkMAIDDateFormat_DMY = 3
    }

    public enum eNkMAIDDateImprintSetting : int
    {
        kNkMAIDDateImprintSetting_Off = 0,        // OFF
        kNkMAIDDateImprintSetting_Date = 1,       // Date
        kNkMAIDDateImprintSetting_Date_Time = 2,  // Date and Time
        kNkMAIDDateImprintSetting_DateCounter = 3 // Date counter
    }

    public enum eNkMAIDDynamicAFArea : int
    {
        kNkMAIDDynamicAFArea_9 = 0,
        kNkMAIDDynamicAFArea_21 = 1,
        kNkMAIDDynamicAFArea_51 = 2,
        kNkMAIDDynamicAFArea_51_3DTtracking = 3
    }

    public enum eNkMAIDEasyExposureCompMode : int
    {
        kNkMAIDEasyExposureCompMode_Off = 0,
        kNkMAIDEasyExposureCompMode_On = 1,
        kNkMAIDEasyExposureCompMode_AutoReset = 2
    }

    public enum eNkMAIDEffectMode : int
    {
        kNkMAIDEffectMode_NightVision = 0,
        kNkMAIDEffectMode_ColorSketch = 1,
        kNkMAIDEffectMode_Miniature = 2,
        kNkMAIDEffectMode_SelectColor = 3,
        kNkMAIDEffectMode_Silhouette = 4,
        kNkMAIDEffectMode_Highkey = 5,
        kNkMAIDEffectMode_Lowkey = 6,
        kNkMAIDEffectMode_ToyCamera = 7,
        kNkMAIDEffectMode_HDRPainting = 8
    }

    public enum eNkMAIDElectronicZoom : int
    {
        kNkMAIDElectronicZoom_100 = 0,
        kNkMAIDElectronicZoom_120 = 1,
        kNkMAIDElectronicZoom_140 = 2,
        kNkMAIDElectronicZoom_160 = 3,
        kNkMAIDElectronicZoom_180 = 4,
        kNkMAIDElectronicZoom_200 = 5,
        kNkMAIDElectronicZoom_220 = 6,
        kNkMAIDElectronicZoom_240 = 7,
        kNkMAIDElectronicZoom_260 = 8,
        kNkMAIDElectronicZoom_280 = 9,
        kNkMAIDElectronicZoom_300 = 10,
        kNkMAIDElectronicZoom_320 = 11,
        kNkMAIDElectronicZoom_340 = 12,
        kNkMAIDElectronicZoom_360 = 13,
        kNkMAIDElectronicZoom_380 = 14,
        kNkMAIDElectronicZoom_400 = 15
    }

    public enum eNkMAIDEnableCommandDialOnPlaybackEx : int
    {
        kNkMAIDEnableCommandDialOnPlaybackEx_Off = 0,
        kNkMAIDEnableCommandDialOnPlaybackEx_On = 1
    }

    public enum eNkMAIDEvent : int
    {
        kNkMAIDEvent_AddChild = 0,
        kNkMAIDEvent_RemoveChild = 1,
        kNkMAIDEvent_WarmingUp = 2,
        kNkMAIDEvent_WarmedUp = 3,
        kNkMAIDEvent_CapChange = 4,
        kNkMAIDEvent_OrphanedChildren = 5,
        kNkMAIDEvent_CapChangeValueOnly = 6,
        kNkMAIDEvent_AddPreviewImage = 263,       // 0x107
        kNkMAIDEvent_CaptureComplete = 264,       // 0x108
        kNkMAIDEvent_AddChildInCard = 265,        // 0x109
        kNkMAIDEvent_RecordingInterrupted = 266,  // 0x10A
        kNkMAIDEvent_CapChangeOperationOnly = 267
    }

    public enum eNkMAIDExchangeDialsEx : int
    {
        kNkMAIDExchangeDialsEx_Off = 0,
        kNkMAIDExchangeDialsEx_On = 1,
        kNkMAIDExchangeDialsEx_On_Amode = 2
    }

    public enum eNkMAIDExposureDelayEx : int
    {
        kNkMAIDExposureDelayEx_3sec = 0,
        kNkMAIDExposureDelayEx_2sec = 1,
        kNkMAIDExposureDelayEx_1sec = 2,
        kNkMAIDExposureDelayEx_Off = 3
    }

    public enum eNkMAIDExposureDisplayStatus : int
    {
        kNkMAIDExposureDisplayStatus_None = 0,
        kNkMAIDExposureDisplayStatus_ShutterSpeedLo = 1,
        kNkMAIDExposureDisplayStatus_ShutterSpeedHi = 2,
        kNkMAIDExposureDisplayStatus_ApertureLo = 3,
        kNkMAIDExposureDisplayStatus_ApertureHi = 4,
        kNkMAIDExposureDisplayStatus_SpLo_ApLo = 5,
        kNkMAIDExposureDisplayStatus_SpLo_ApHi = 6,
        kNkMAIDExposureDisplayStatus_SpHi_ApLo = 7,
        kNkMAIDExposureDisplayStatus_SpHi_ApHi = 8
    }

    public enum eNkMAIDExposureMeterLinkage : int
    {
        kNkMAIDExposureMeterLinkage_AI = 0,
        kNkMAIDExposureMeterLinkage_NON_AI = 1
    }

    public enum eNkMAIDExposureMode : int
    {
        kNkMAIDExposureMode_Program = 0,
        kNkMAIDExposureMode_AperturePriority = 1,
        kNkMAIDExposureMode_SpeedPriority = 2,
        kNkMAIDExposureMode_Manual = 3,
        kNkMAIDExposureMode_Disable = 4,
        kNkMAIDExposureMode_Auto = 5,
        kNkMAIDExposureMode_Portrait = 6,
        kNkMAIDExposureMode_Landscape = 7,
        kNkMAIDExposureMode_Closeup = 8,
        kNkMAIDExposureMode_Sports = 9,
        kNkMAIDExposureMode_NightPortrait = 10,
        kNkMAIDExposureMode_NightView = 11,
        kNkMAIDExposureMode_Child = 12,
        kNkMAIDExposureMode_FlashOff = 13,
        kNkMAIDExposureMode_Scene = 14,
        kNkMAIDExposureMode_UserMode1 = 15,
        kNkMAIDExposureMode_UserMode2 = 16,
        kNkMAIDExposureMode_Effects = 17
    }

    public enum eNkMAIDExternalFlashSort : int
    {
        kNkMAIDExternalFlashSort_NoCommunicate = 0,
        kNkMAIDExternalFlashSort_OldType = 1,
        kNkMAIDExternalFlashSort_NewType = 2,
        kNkMAIDExternalFlashSort_NotExist = 3,
        kNkMAIDExternalFlashSort_NewTypeControl = 4
    }

    public enum eNkMAIDExternalFlashStatus : int
    {
        kNkMAIDExternalFlashStatus_Ready = 0,
        kNkMAIDExternalFlashStatus_NotReady = 1,
        kNkMAIDExternalFlashStatus_NotExist = 2
    }

    public enum eNkMAIDExternalNewTypeFlashMode : int
    {
        kNkMAIDExternalNewTypeFlashMode_OFF = 0,
        kNkMAIDExternalNewTypeFlashMode_CompTTL = 1,
        kNkMAIDExternalNewTypeFlashMode_NoCompTTL = 2,
        kNkMAIDExternalNewTypeFlashMode_AA = 3,
        kNkMAIDExternalNewTypeFlashMode_ExtAutoFlash = 4,
        kNkMAIDExternalNewTypeFlashMode_ManualLengthPriority = 5,
        kNkMAIDExternalNewTypeFlashMode_Manual = 6,
        kNkMAIDExternalNewTypeFlashMode_Multi = 7,
        kNkMAIDExternalNewTypeFlashMode_NotExist = 8
    }

    public enum eNkMAIDExternalOldTypeFlashMode : int
    {
        kNkMAIDExternalOldTypeFlashMode_TTL = 0,
        kNkMAIDExternalOldTypeFlashMode_DTTL = 1,
        kNkMAIDExternalOldTypeFlashMode_AA = 2,
        kNkMAIDExternalOldTypeFlashMode_ExtAutoFlash = 3,
        kNkMAIDExternalOldTypeFlashMode_Manual = 4,
        kNkMAIDExternalOldTypeFlashMode_FP = 5,
        kNkMAIDExternalOldTypeFlashMode_NotExist = 6,
        kNkMAIDExternalOldTypeFlashMode_NonTTL = 7
    }

    public enum eNkMAIDExternalSplValue : int
    {
        kNkMAIDExternalSplValue_Full = 0, // Full
        kNkMAIDExternalSplValue_2 = 1,    // 1/2
        kNkMAIDExternalSplValue_4 = 2,    // 1/4
        kNkMAIDExternalSplValue_8 = 3,    // 1/8
        kNkMAIDExternalSplValue_16 = 4,   // 1/16
        kNkMAIDExternalSplValue_32 = 5,   // 1/32
        kNkMAIDExternalSplValue_64 = 6,   // 1/64
        kNkMAIDExternalSplValue_128 = 7,  // 1/128
        kNkMAIDExternalSplValue_256 = 8   // 1/256
    }

    public enum eNkMAIDFileDataType : int
    {
        kNkMAIDFileDataType_NotSpecified = 0,
        kNkMAIDFileDataType_JPEG = 1,
        kNkMAIDFileDataType_TIFF = 2,
        kNkMAIDFileDataType_FlashPix = 3,
        kNkMAIDFileDataType_NIF = 4,
        kNkMAIDFileDataType_QuickTime = 5,
        kNkMAIDFileDataType_VendorBaseDx2 = 256, // 0x100
        kNkMAIDFileDataType_UserType = 256,
        kNkMAIDFileDataType_NDF = 257,
        kNkMAIDFileDataType_AVI = 258,
        kNkMAIDFileDataType_MOV = 259
    }

    public enum eNkMAIDFilter : int
    {
        kNkMAIDFilter_White = 0,
        kNkMAIDFilter_Infrared = 1,
        kNkMAIDFilter_Red = 2,
        kNkMAIDFilter_Green = 3,
        kNkMAIDFilter_Blue = 4,
        kNkMAIDFilter_Ultraviolet = 5
    }

    public enum eNkMAIDFinderISODisplay : int
    {
        kNkMAIDFinderISODisplay_ISO = 0,
        kNkMAIDFinderISODisplay_EasyISO = 1,
        kNkMAIDFinderISODisplay_FrameCount = 2
    }

    public enum eNkMAIDFlashMode : int
    {
        kNkMAIDFlashMode_FrontCurtain = 0,
        kNkMAIDFlashMode_RearCurtain = 1,
        kNkMAIDFlashMode_SlowSync = 2,
        kNkMAIDFlashMode_RedEyeReduction = 3,
        kNkMAIDFlashMode_SlowSyncRedEyeReduction = 4,
        kNkMAIDFlashMode_SlowSyncRearCurtain = 5,
        kNkMAIDFlashMode_VendorBaseDx2 = 261,
        kNkMAIDFlashMode_Off = 262,
        kNkMAIDFlashMode_Auto = 263,
        kNkMAIDFlashMode_On = 264
    }

    public enum eNkMAIDFlashStatus : int
    {
        kNkMAIDFlashStatus_Ready = 0,
        kNkMAIDFlashStatus_NotReady = 1,
        kNkMAIDFlashStatus_NotExist = 2,
        kNkMAIDFlashStatus_NormalTTL = 3
    }

    public enum eNkMAIDFmmManual : int
    {
        kNkMAIDFmmManual_0 = 0,
        kNkMAIDFmmManual_6 = 6,
        kNkMAIDFmmManual_8 = 8,
        kNkMAIDFmmManual_13 = 13,
        kNkMAIDFmmManual_15 = 15,
        kNkMAIDFmmManual_16 = 16,
        kNkMAIDFmmManual_18 = 18,
        kNkMAIDFmmManual_20 = 20,
        kNkMAIDFmmManual_24 = 24,
        kNkMAIDFmmManual_25 = 25,
        kNkMAIDFmmManual_28 = 28,
        kNkMAIDFmmManual_35 = 35,
        kNkMAIDFmmManual_43 = 43,
        kNkMAIDFmmManual_45 = 45,
        kNkMAIDFmmManual_50 = 50,
        kNkMAIDFmmManual_55 = 55,
        kNkMAIDFmmManual_58 = 58,
        kNkMAIDFmmManual_70 = 70,
        kNkMAIDFmmManual_80 = 80,
        kNkMAIDFmmManual_85 = 85,
        kNkMAIDFmmManual_86 = 86,
        kNkMAIDFmmManual_100 = 100,
        kNkMAIDFmmManual_105 = 105,
        kNkMAIDFmmManual_135 = 135,
        kNkMAIDFmmManual_180 = 180,
        kNkMAIDFmmManual_200 = 200,
        kNkMAIDFmmManual_300 = 300,
        kNkMAIDFmmManual_360 = 360,
        kNkMAIDFmmManual_400 = 400,
        kNkMAIDFmmManual_500 = 500,
        kNkMAIDFmmManual_600 = 600,
        kNkMAIDFmmManual_800 = 800,
        kNkMAIDFmmManual_1000 = 1000,
        kNkMAIDFmmManual_1200 = 1200,
        kNkMAIDFmmManual_1400 = 1400,
        kNkMAIDFmmManual_1600 = 1600,
        kNkMAIDFmmManual_2000 = 2000,
        kNkMAIDFmmManual_2400 = 2400,
        kNkMAIDFmmManual_2800 = 2800,
        kNkMAIDFmmManual_3200 = 3200,
        kNkMAIDFmmManual_4000 = 4000
    }

    public enum eNkMAIDFocusAreaFrame : int
    {
        kNkMAIDFocusAreaFrame_Normal = 0,
        kNkMAIDFocusAreaFrame_Wide = 1
    }

    public enum eNkMAIDFocusGroupPreferred : int
    {
        kNkMAIDFocusGroupPreferred_Center = 0,
        kNkMAIDFocusGroupPreferred_Upper = 1,
        kNkMAIDFocusGroupPreferred_Bottom = 2,
        kNkMAIDFocusGroupPreferred_Left = 3,
        kNkMAIDFocusGroupPreferred_Right = 4
    }

    public enum eNkMAIDFocusMode : int
    {
        kNkMAIDFocusMode_MF = 0,
        kNkMAIDFocusMode_AFs = 1,
        kNkMAIDFocusMode_AFc = 2,
        kNkMAIDFocusMode_AFa = 3,
        kNkMAIDFocusMode_AFf = 4,
        kNkMAIDFocusMode_AF = 16,
        kNkMAIDFocusMode_Macro = 17,
        kNkMAIDFocusMode_Infinity = 18
    }

    public enum eNkMAIDFocusPointBrightness : int
    {
        kNkMAIDFocusPointBrightness_Low = 0,
        kNkMAIDFocusPointBrightness_Normal = 1,
        kNkMAIDFocusPointBrightness_High = 2,
        kNkMAIDFocusPointBrightness_ExtraHigh = 3
    }

    public enum eNkMAIDFocusPreferred : int
    {
        kNkMAIDFocusPreferred_Center = 0,
        kNkMAIDFocusPreferred_Upper = 1,
        kNkMAIDFocusPreferred_Bottom = 2,
        kNkMAIDFocusPreferred_Left = 3,
        kNkMAIDFocusPreferred_Right = 4,
        kNkMAIDFocusPreferred_UpperLeft = 5,
        kNkMAIDFocusPreferred_UpperRight = 6,
        kNkMAIDFocusPreferred_BottomLeft = 7,
        kNkMAIDFocusPreferred_BottomRight = 8,
        kNkMAIDFocusPreferred_LeftEnd = 9,
        kNkMAIDFocusPreferred_RightEnd = 10
    }

    public enum eNkMAIDFocusPreferred2 : int
    {
        kNkMAIDFocusPreferred2_Unknown = 0,
        kNkMAIDFocusPreferred2_C = 1,
        kNkMAIDFocusPreferred2_CT = 2,
        kNkMAIDFocusPreferred2_CTT = 3,
        kNkMAIDFocusPreferred2_CB = 4,
        kNkMAIDFocusPreferred2_CBB = 5,
        kNkMAIDFocusPreferred2_CR = 6,
        kNkMAIDFocusPreferred2_CRT = 7,
        kNkMAIDFocusPreferred2_CRTT = 8,
        kNkMAIDFocusPreferred2_CRB = 9,
        kNkMAIDFocusPreferred2_CRBB = 10,
        kNkMAIDFocusPreferred2_CL = 11,
        kNkMAIDFocusPreferred2_CLT = 12,
        kNkMAIDFocusPreferred2_CLTT = 13,
        kNkMAIDFocusPreferred2_CLB = 14,
        kNkMAIDFocusPreferred2_CLBB = 15,
        kNkMAIDFocusPreferred2_RA = 16,
        kNkMAIDFocusPreferred2_RAT = 17,
        kNkMAIDFocusPreferred2_RATT = 18,
        kNkMAIDFocusPreferred2_RAB = 19,
        kNkMAIDFocusPreferred2_RABB = 20,
        kNkMAIDFocusPreferred2_RB = 21,
        kNkMAIDFocusPreferred2_RBT = 22,
        kNkMAIDFocusPreferred2_RBTT = 23,
        kNkMAIDFocusPreferred2_RBB = 24,
        kNkMAIDFocusPreferred2_RBBB = 25,
        kNkMAIDFocusPreferred2_RC = 26,
        kNkMAIDFocusPreferred2_RCT = 27,
        kNkMAIDFocusPreferred2_RCTT = 28,
        kNkMAIDFocusPreferred2_RCB = 29,
        kNkMAIDFocusPreferred2_RCBB = 30,
        kNkMAIDFocusPreferred2_RD = 31,
        kNkMAIDFocusPreferred2_RDT = 32,
        kNkMAIDFocusPreferred2_RDB = 33,
        kNkMAIDFocusPreferred2_LA = 34,
        kNkMAIDFocusPreferred2_LAT = 35,
        kNkMAIDFocusPreferred2_LATT = 36,
        kNkMAIDFocusPreferred2_LAB = 37,
        kNkMAIDFocusPreferred2_LABB = 38,
        kNkMAIDFocusPreferred2_LB = 39,
        kNkMAIDFocusPreferred2_LBT = 40,
        kNkMAIDFocusPreferred2_LBTT = 41,
        kNkMAIDFocusPreferred2_LBB = 42,
        kNkMAIDFocusPreferred2_LBBB = 43,
        kNkMAIDFocusPreferred2_LC = 44,
        kNkMAIDFocusPreferred2_LCT = 45,
        kNkMAIDFocusPreferred2_LCTT = 46,
        kNkMAIDFocusPreferred2_LCB = 47,
        kNkMAIDFocusPreferred2_LCBB = 48,
        kNkMAIDFocusPreferred2_LD = 49,
        kNkMAIDFocusPreferred2_LDT = 50,
        kNkMAIDFocusPreferred2_LDB = 51
    }

    public enum eNkMAIDFocusPreferred3 : int
    {
        kNkMAIDFocusPreferred3_Unknown = 0,
        kNkMAIDFocusPreferred3_Center = 1,
        kNkMAIDFocusPreferred3_Upper = 2,
        kNkMAIDFocusPreferred3_Bottom = 3,
        kNkMAIDFocusPreferred3_Left = 4,
        kNkMAIDFocusPreferred3_UpperLeft = 5,
        kNkMAIDFocusPreferred3_BottomLeft = 6,
        kNkMAIDFocusPreferred3_LeftEnd = 7,
        kNkMAIDFocusPreferred3_Right = 8,
        kNkMAIDFocusPreferred3_UpperRight = 9,
        kNkMAIDFocusPreferred3_BottomRight = 10,
        kNkMAIDFocusPreferred3_RightEnd = 11
    }

    public enum eNkMAIDFocusPreferred4 : int
    {
        kNkMAIDFocusPreferred4_Unknown = 0,
        kNkMAIDFocusPreferred4_C = 1,
        kNkMAIDFocusPreferred4_CT = 2,
        kNkMAIDFocusPreferred4_CTT = 3,
        kNkMAIDFocusPreferred4_CB = 4,
        kNkMAIDFocusPreferred4_CBB = 5,
        kNkMAIDFocusPreferred4_CR = 6,
        kNkMAIDFocusPreferred4_CRT = 7,
        kNkMAIDFocusPreferred4_CRTT = 8,
        kNkMAIDFocusPreferred4_CRB = 9,
        kNkMAIDFocusPreferred4_CRBB = 10,
        kNkMAIDFocusPreferred4_CL = 11,
        kNkMAIDFocusPreferred4_CLT = 12,
        kNkMAIDFocusPreferred4_CLTT = 13,
        kNkMAIDFocusPreferred4_CLB = 14,
        kNkMAIDFocusPreferred4_CLBB = 15,
        kNkMAIDFocusPreferred4_RA = 16,
        kNkMAIDFocusPreferred4_RAT = 17,
        kNkMAIDFocusPreferred4_RAB = 18,
        kNkMAIDFocusPreferred4_RB = 19,
        kNkMAIDFocusPreferred4_RBT = 20,
        kNkMAIDFocusPreferred4_RBB = 21,
        kNkMAIDFocusPreferred4_RC = 22,
        kNkMAIDFocusPreferred4_RCT = 23,
        kNkMAIDFocusPreferred4_RCB = 24,
        kNkMAIDFocusPreferred4_RD = 25,
        kNkMAIDFocusPreferred4_RDT = 26,
        kNkMAIDFocusPreferred4_RDB = 27,
        kNkMAIDFocusPreferred4_LA = 28,
        kNkMAIDFocusPreferred4_LAT = 29,
        kNkMAIDFocusPreferred4_LAB = 30,
        kNkMAIDFocusPreferred4_LB = 31,
        kNkMAIDFocusPreferred4_LBT = 32,
        kNkMAIDFocusPreferred4_LBB = 33,
        kNkMAIDFocusPreferred4_LC = 34,
        kNkMAIDFocusPreferred4_LCT = 35,
        kNkMAIDFocusPreferred4_LCB = 36,
        kNkMAIDFocusPreferred4_LD = 37,
        kNkMAIDFocusPreferred4_LDT = 38,
        kNkMAIDFocusPreferred4_LDB = 39
    }

    public enum eNkMAIDGetIPTCInfo : int
    {
        kNkMAIDGetIPTCInfo_None = 0,
        kNkMAIDGetIPTCInfo_Attached = 1
    }

    public enum eNkMAIDHDRExposure : int
    {
        kNkMAIDHDRExposure_Auto = 0,
        kNkMAIDHDRExposure_1EV = 1,
        kNkMAIDHDRExposure_2EV = 2,
        kNkMAIDHDRExposure_3EV = 3
    }

    public enum eNkMAIDHDRMode : int
    {
        kNkMAIDHDRMode_Off = 0,
        kNkMAIDHDRMode_On = 1,
        kNkMAIDHDRMode_Continuous = 2
    }

    public enum eNkMAIDHDRMode2 : int
    {
        kNkMAIDHDRMode2_Off = 0,
        kNkMAIDHDRMode2_Low = 1,
        kNkMAIDHDRMode2_Normal = 2,
        kNkMAIDHDRMode2_High = 3,
        kNkMAIDHDRMode2_ExtraHigh = 4,
        kNkMAIDHDRMode2_Auto = 5
    }

    public enum eNkMAIDHDRSmoothing : int
    {
        kNkMAIDHDRSmoothing_High = 0,
        kNkMAIDHDRSmoothing_Normal = 1,
        kNkMAIDHDRSmoothing_Low = 2,
        kNkMAIDHDRSmoothing_Auto = 3,
        kNkMAIDHDRSmoothing_ExtraHigh = 4
    }

    public enum eNkMAIDIlluminationSetting : int
    {
        kNkMAIDIlluminationSetting_LCDBacklight = 0,
        kNkMAIDIlluminationSetting_Both = 1
    }

    public enum eNkMAIDImageColorSpace : int
    {
        kNkMAIDImageColorSpace_sRGB = 0,
        kNkMAIDImageColorSpace_AdobeRGB = 1
    }

    public enum eNkMAIDImageSetting : int
    {
        kNkMAIDImageSetting_Normal = 0,
        kNkMAIDImageSetting_Clear = 1,
        kNkMAIDImageSetting_Sharp = 2,
        kNkMAIDImageSetting_Soft = 3,
        kNkMAIDImageSetting_DirectPrint = 4,
        kNkMAIDImageSetting_Portrait = 5,
        kNkMAIDImageSetting_Landscape = 6,
        kNkMAIDImageSetting_Custom = 7,
        kNkMAIDImageSetting_Black_and_White = 8,
        kNkMAIDImageSetting_MoreClear = 9
    }

    public enum eNkMAIDIndicatorDisplay : int
    {
        kNkMAIDIndicatorDisplay_Plus = 0,
        kNkMAIDIndicatorDisplay_Minus = 1
    }

    public enum eNkMAIDInfoDispSetting : int
    {
        kNkMAIDInfoDispSetting_Auto = 0,
        kNkMAIDInfoDispSetting_M_DarkOnLight = 1,
        kNkMAIDInfoDispSetting_M_LightOnDark = 2
    }

    public enum eNkMAIDInternalFlashStatus : int
    {
        kNkMAIDInternalFlashStatus_Ready = 0,
        kNkMAIDInternalFlashStatus_NotReady = 1,
        kNkMAIDInternalFlashStatus_Close = 2,
        kNkMAIDInternalFlashStatus_TTL = 3
    }

    public enum eNkMAIDInternalSplCmdGroupComp : int
    {
        kNkMAIDInternalSplCmdGroupComp_M30 = 0,  // -3.0
        kNkMAIDInternalSplCmdGroupComp_M27 = 1,  // -2.7
        kNkMAIDInternalSplCmdGroupComp_M23 = 2,  // -2.3
        kNkMAIDInternalSplCmdGroupComp_M20 = 3,  // -2.0
        kNkMAIDInternalSplCmdGroupComp_M17 = 4,  // -1.7
        kNkMAIDInternalSplCmdGroupComp_M13 = 5,  // -1.3
        kNkMAIDInternalSplCmdGroupComp_M10 = 6,  // -1.0
        kNkMAIDInternalSplCmdGroupComp_M07 = 7,  // -0.7
        kNkMAIDInternalSplCmdGroupComp_M03 = 8,  // -0.3
        kNkMAIDInternalSplCmdGroupComp_0 = 9,    // 0
        kNkMAIDInternalSplCmdGroupComp_P03 = 10, // +0.3
        kNkMAIDInternalSplCmdGroupComp_P07 = 11, // +0.7
        kNkMAIDInternalSplCmdGroupComp_P10 = 12, // +1.0
        kNkMAIDInternalSplCmdGroupComp_P13 = 13, // +1.3
        kNkMAIDInternalSplCmdGroupComp_P17 = 14, // +1.7
        kNkMAIDInternalSplCmdGroupComp_P20 = 15, // +2.0
        kNkMAIDInternalSplCmdGroupComp_P23 = 16, // +2.3
        kNkMAIDInternalSplCmdGroupComp_P27 = 17, // +2.7
        kNkMAIDInternalSplCmdGroupComp_P30 = 18  // +3.0
    }

    public enum eNkMAIDInternalSplCmdGroupMode : int
    {
        kNkMAIDInternalSplCmdGroupMode_TTL = 0,
        kNkMAIDInternalSplCmdGroupMode_AA = 1,
        kNkMAIDInternalSplCmdGroupMode_Manual = 2,
        kNkMAIDInternalSplCmdGroupMode_Off = 3
    }

    public enum eNkMAIDInternalSplCmdGroupValue : int
    {
        kNkMAIDInternalSplCmdGroupValue_1 = 0,    // 1/1
        kNkMAIDInternalSplCmdGroupValue_2 = 1,    // 1/2
        kNkMAIDInternalSplCmdGroupValue_4 = 2,    // 1/4
        kNkMAIDInternalSplCmdGroupValue_8 = 3,    // 1/8
        kNkMAIDInternalSplCmdGroupValue_16 = 4,   // 1/16
        kNkMAIDInternalSplCmdGroupValue_32 = 5,   // 1/32
        kNkMAIDInternalSplCmdGroupValue_64 = 6,   // 1/64
        kNkMAIDInternalSplCmdGroupValue_128 = 7,  // 1/128
        kNkMAIDInternalSplCmdGroupValue_1_3 = 8,  // 1/1.3
        kNkMAIDInternalSplCmdGroupValue_1_7 = 9,  // 1/1.7
        kNkMAIDInternalSplCmdGroupValue_2_5 = 10, // 1/2.5
        kNkMAIDInternalSplCmdGroupValue_3_2 = 11, // 1/3.2
        kNkMAIDInternalSplCmdGroupValue_5 = 12,   // 1/5
        kNkMAIDInternalSplCmdGroupValue_6_4 = 13, // 1/6.4
        kNkMAIDInternalSplCmdGroupValue_10 = 14,  // 1/10
        kNkMAIDInternalSplCmdGroupValue_13 = 15,  // 1/13
        kNkMAIDInternalSplCmdGroupValue_20 = 16,  // 1/20
        kNkMAIDInternalSplCmdGroupValue_25 = 17,  // 1/25
        kNkMAIDInternalSplCmdGroupValue_40 = 18,  // 1/40
        kNkMAIDInternalSplCmdGroupValue_50 = 19,  // 1/50
        kNkMAIDInternalSplCmdGroupValue_80 = 20,  // 1/80
        kNkMAIDInternalSplCmdGroupValue_100 = 21  // 1/100
    }

    public enum eNkMAIDInternalSplCmdSelfComp : int
    {
        kNkMAIDInternalSplCmdSelfComp_M30 = 0,
        kNkMAIDInternalSplCmdSelfComp_M27 = 1,
        kNkMAIDInternalSplCmdSelfComp_M23 = 2,
        kNkMAIDInternalSplCmdSelfComp_M20 = 3,
        kNkMAIDInternalSplCmdSelfComp_M17 = 4,
        kNkMAIDInternalSplCmdSelfComp_M13 = 5,
        kNkMAIDInternalSplCmdSelfComp_M10 = 6,
        kNkMAIDInternalSplCmdSelfComp_M07 = 7,
        kNkMAIDInternalSplCmdSelfComp_M03 = 8,
        kNkMAIDInternalSplCmdSelfComp_0 = 9,
        kNkMAIDInternalSplCmdSelfComp_P03 = 10,
        kNkMAIDInternalSplCmdSelfComp_P07 = 11,
        kNkMAIDInternalSplCmdSelfComp_P10 = 12,
        kNkMAIDInternalSplCmdSelfComp_P13 = 13,
        kNkMAIDInternalSplCmdSelfComp_P17 = 14,
        kNkMAIDInternalSplCmdSelfComp_P20 = 15,
        kNkMAIDInternalSplCmdSelfComp_P23 = 16,
        kNkMAIDInternalSplCmdSelfComp_P27 = 17,
        kNkMAIDInternalSplCmdSelfComp_P30 = 18
    }

    public enum eNkMAIDInternalSplCmdSelfMode : int
    {
        kNkMAIDInternalSplCmdSelfMode_TTL = 0,
        kNkMAIDInternalSplCmdSelfMode_Manual = 1,
        kNkMAIDInternalSplCmdSelfMode_Off = 2
    }

    public enum eNkMAIDInternalSplCmdSelfValue : int
    {
        kNkMAIDInternalSplCmdSelfValue_1 = 0,    // 1/1
        kNkMAIDInternalSplCmdSelfValue_2 = 1,    // 1/2
        kNkMAIDInternalSplCmdSelfValue_4 = 2,    // 1/4
        kNkMAIDInternalSplCmdSelfValue_8 = 3,    // 1/8
        kNkMAIDInternalSplCmdSelfValue_16 = 4,   // 1/16
        kNkMAIDInternalSplCmdSelfValue_32 = 5,   // 1/32
        kNkMAIDInternalSplCmdSelfValue_64 = 6,   // 1/64
        kNkMAIDInternalSplCmdSelfValue_128 = 7,  // 1/128
        kNkMAIDInternalSplCmdSelfValue_1_3 = 8,  // 1/1.3
        kNkMAIDInternalSplCmdSelfValue_1_7 = 9,  // 1/1.7
        kNkMAIDInternalSplCmdSelfValue_2_5 = 10, // 1/2.5
        kNkMAIDInternalSplCmdSelfValue_3_2 = 11, // 1/3.2
        kNkMAIDInternalSplCmdSelfValue_5 = 12,   // 1/5
        kNkMAIDInternalSplCmdSelfValue_6_4 = 13, // 1/6.4
        kNkMAIDInternalSplCmdSelfValue_10 = 14,  // 1/10
        kNkMAIDInternalSplCmdSelfValue_13 = 15,  // 1/13
        kNkMAIDInternalSplCmdSelfValue_20 = 16,  // 1/20
        kNkMAIDInternalSplCmdSelfValue_25 = 17,  // 1/25
        kNkMAIDInternalSplCmdSelfValue_40 = 18,  // 1/40
        kNkMAIDInternalSplCmdSelfValue_50 = 19,  // 1/50
        kNkMAIDInternalSplCmdSelfValue_80 = 20,  // 1/80
        kNkMAIDInternalSplCmdSelfValue_100 = 21  // 1/100
    }

    public enum eNkMAIDInternalSplCommand : int
    {
        kNkMAIDInternalSplCommand_TTL = 0,
        kNkMAIDInternalSplCommand_AA = 1,
        kNkMAIDInternalSplCommand_Manual = 2,
        kNkMAIDInternalSplCommand_Off = 3
    }

    public enum eNkMAIDInternalSplCommandChannel : int
    {
        kNkMAIDInternalSplCommandChannel_1 = 0,
        kNkMAIDInternalSplCommandChannel_2 = 1,
        kNkMAIDInternalSplCommandChannel_3 = 2,
        kNkMAIDInternalSplCommandChannel_4 = 3
    }

    public enum eNkMAIDInternalSplMRPTCount : int
    {
        kNkMAIDInternalSplMRPTCount_2 = 0,
        kNkMAIDInternalSplMRPTCount_3 = 1,
        kNkMAIDInternalSplMRPTCount_4 = 2,
        kNkMAIDInternalSplMRPTCount_5 = 3,
        kNkMAIDInternalSplMRPTCount_6 = 4,
        kNkMAIDInternalSplMRPTCount_7 = 5,
        kNkMAIDInternalSplMRPTCount_8 = 6,
        kNkMAIDInternalSplMRPTCount_9 = 7,
        kNkMAIDInternalSplMRPTCount_10 = 8,
        kNkMAIDInternalSplMRPTCount_15 = 9,
        kNkMAIDInternalSplMRPTCount_20 = 10,
        kNkMAIDInternalSplMRPTCount_25 = 11,
        kNkMAIDInternalSplMRPTCount_30 = 12,
        kNkMAIDInternalSplMRPTCount_35 = 13
    }

    public enum eNkMAIDInternalSplMRPTInterval : int
    {
        kNkMAIDInternalSplMRPTInterval_1 = 0,
        kNkMAIDInternalSplMRPTInterval_2 = 1,
        kNkMAIDInternalSplMRPTInterval_3 = 2,
        kNkMAIDInternalSplMRPTInterval_4 = 3,
        kNkMAIDInternalSplMRPTInterval_5 = 4,
        kNkMAIDInternalSplMRPTInterval_6 = 5,
        kNkMAIDInternalSplMRPTInterval_7 = 6,
        kNkMAIDInternalSplMRPTInterval_8 = 7,
        kNkMAIDInternalSplMRPTInterval_9 = 8,
        kNkMAIDInternalSplMRPTInterval_10 = 9,
        kNkMAIDInternalSplMRPTInterval_20 = 10,
        kNkMAIDInternalSplMRPTInterval_30 = 11,
        kNkMAIDInternalSplMRPTInterval_40 = 12,
        kNkMAIDInternalSplMRPTInterval_50 = 13
    }

    public enum eNkMAIDInternalSplMRPTValue : int
    {
        kNkMAIDInternalSplMRPTValue_4 = 0,
        kNkMAIDInternalSplMRPTValue_8 = 1,
        kNkMAIDInternalSplMRPTValue_16 = 2,
        kNkMAIDInternalSplMRPTValue_32 = 3,
        kNkMAIDInternalSplMRPTValue_64 = 4,
        kNkMAIDInternalSplMRPTValue_128 = 5,
        kNkMAIDInternalSplMRPTValue_Full = 6
    }

    public enum eNkMAIDInternalSplValue : int
    {
        kNkMAIDInternalSplValue_Full = 0, // Full
        kNkMAIDInternalSplValue_2 = 1,    // 1/2
        kNkMAIDInternalSplValue_4 = 2,    // 1/4
        kNkMAIDInternalSplValue_8 = 3,    // 1/8
        kNkMAIDInternalSplValue_16 = 4,   // 1/16
        kNkMAIDInternalSplValue_32 = 5,   // 1/32
        kNkMAIDInternalSplValue_64 = 6,   // 1/64
        kNkMAIDInternalSplValue_128 = 7,  // 1/128
        kNkMAIDInternalSplValue_1_3 = 8,  // 1/1.3
        kNkMAIDInternalSplValue_1_7 = 9,  // 1/1.7
        kNkMAIDInternalSplValue_2_5 = 10, // 1/2.5
        kNkMAIDInternalSplValue_3_2 = 11, // 1/3.2
        kNkMAIDInternalSplValue_5 = 12,   // 1/5
        kNkMAIDInternalSplValue_6_4 = 13, // 1/6.4
        kNkMAIDInternalSplValue_10 = 14,  // 1/10
        kNkMAIDInternalSplValue_13 = 15,  // 1/13
        kNkMAIDInternalSplValue_20 = 16,  // 1/20
        kNkMAIDInternalSplValue_25 = 17,  // 1/25
        kNkMAIDInternalSplValue_40 = 18,  // 1/40
        kNkMAIDInternalSplValue_50 = 19,  // 1/50
        kNkMAIDInternalSplValue_80 = 20,  // 1/80
        kNkMAIDInternalSplValue_100 = 21, // 1/100
        kNkMAIDInternalSplValue_256 = 22  // 1/256
    }

    public enum eNkMAIDISOAutoHiLimit : int
    {
        kNkMAIDISOAutoHiLimit_ISO200 = 0,
        kNkMAIDISOAutoHiLimit_ISO400 = 1,
        kNkMAIDISOAutoHiLimit_ISO800 = 2,
        kNkMAIDISOAutoHiLimit_ISO1600 = 3,
        kNkMAIDISOAutoHiLimit_ISO3200 = 4,
        kNkMAIDISOAutoHiLimit_ISO6400 = 5,
        kNkMAIDISOAutoHiLimit_Hi1 = 6,
        kNkMAIDISOAutoHiLimit_Hi2 = 7,
        kNkMAIDISOAutoHiLimit_ISO12800 = 8
    }

    public enum eNkMAIDISOAutoHiLimit2 : int
    {
        kNkMAIDISOAutoHiLimit2_ISO400 = 0,
        kNkMAIDISOAutoHiLimit2_ISO500 = 1,
        kNkMAIDISOAutoHiLimit2_ISO560 = 2,
        kNkMAIDISOAutoHiLimit2_ISO640 = 3,
        kNkMAIDISOAutoHiLimit2_ISO800 = 4,
        kNkMAIDISOAutoHiLimit2_ISO1000 = 5,
        kNkMAIDISOAutoHiLimit2_ISO1100 = 6,
        kNkMAIDISOAutoHiLimit2_ISO1250 = 7,
        kNkMAIDISOAutoHiLimit2_ISO1600 = 8,
        kNkMAIDISOAutoHiLimit2_ISO2000 = 9,
        kNkMAIDISOAutoHiLimit2_ISO2200 = 10,
        kNkMAIDISOAutoHiLimit2_ISO2500 = 11,
        kNkMAIDISOAutoHiLimit2_ISO3200 = 12,
        kNkMAIDISOAutoHiLimit2_ISO4000 = 13,
        kNkMAIDISOAutoHiLimit2_ISO4500 = 14,
        kNkMAIDISOAutoHiLimit2_ISO5000 = 15,
        kNkMAIDISOAutoHiLimit2_ISO6400 = 16,
        kNkMAIDISOAutoHiLimit2_ISO8000 = 17,
        kNkMAIDISOAutoHiLimit2_ISO9000 = 18,
        kNkMAIDISOAutoHiLimit2_ISO10000 = 19,
        kNkMAIDISOAutoHiLimit2_ISO12800 = 20,
        kNkMAIDISOAutoHiLimit2_ISOHi03 = 21,
        kNkMAIDISOAutoHiLimit2_ISOHi05 = 22,
        kNkMAIDISOAutoHiLimit2_ISOHi07 = 23,
        kNkMAIDISOAutoHiLimit2_ISOHi10 = 24,
        kNkMAIDISOAutoHiLimit2_ISOHi20 = 25,
        kNkMAIDISOAutoHiLimit2_ISOHi30 = 26
    }

    public enum eNkMAIDISOAutoHiLimit3 : int
    {
        kNkMAIDISOAutoHiLimit3_ISO200 = 0,
        kNkMAIDISOAutoHiLimit3_ISO250 = 1,
        kNkMAIDISOAutoHiLimit3_ISO280 = 2,
        kNkMAIDISOAutoHiLimit3_ISO320 = 3,
        kNkMAIDISOAutoHiLimit3_ISO400 = 4,
        kNkMAIDISOAutoHiLimit3_ISO500 = 5,
        kNkMAIDISOAutoHiLimit3_ISO560 = 6,
        kNkMAIDISOAutoHiLimit3_ISO640 = 7,
        kNkMAIDISOAutoHiLimit3_ISO800 = 8,
        kNkMAIDISOAutoHiLimit3_ISO1000 = 9,
        kNkMAIDISOAutoHiLimit3_ISO1100 = 10,
        kNkMAIDISOAutoHiLimit3_ISO1250 = 11,
        kNkMAIDISOAutoHiLimit3_ISO1600 = 12,
        kNkMAIDISOAutoHiLimit3_ISO2000 = 13,
        kNkMAIDISOAutoHiLimit3_ISO2200 = 14,
        kNkMAIDISOAutoHiLimit3_ISO2500 = 15,
        kNkMAIDISOAutoHiLimit3_ISO3200 = 16,
        kNkMAIDISOAutoHiLimit3_ISO4000 = 17,
        kNkMAIDISOAutoHiLimit3_ISO4500 = 18,
        kNkMAIDISOAutoHiLimit3_ISO5000 = 19,
        kNkMAIDISOAutoHiLimit3_ISO6400 = 20,
        kNkMAIDISOAutoHiLimit3_ISOHi03 = 21,
        kNkMAIDISOAutoHiLimit3_ISOHi05 = 22,
        kNkMAIDISOAutoHiLimit3_ISOHi07 = 23,
        kNkMAIDISOAutoHiLimit3_ISOHi10 = 24,
        kNkMAIDISOAutoHiLimit3_ISOHi20 = 25,
        kNkMAIDISOAutoHiLimit3_ISO8000 = 26,
        kNkMAIDISOAutoHiLimit3_ISO9000 = 27,
        kNkMAIDISOAutoHiLimit3_ISO10000 = 28,
        kNkMAIDISOAutoHiLimit3_ISO12800 = 29,
        kNkMAIDISOAutoHiLimit3_ISOHi30 = 30,
        kNkMAIDISOAutoHiLimit3_ISOHi40 = 31,
        kNkMAIDISOAutoHiLimit3_ISO16000 = 32,
        kNkMAIDISOAutoHiLimit3_ISO18000 = 33,
        kNkMAIDISOAutoHiLimit3_ISO20000 = 34,
        kNkMAIDISOAutoHiLimit3_ISO25600 = 35
    }

    public enum eNkMAIDISOAutoHiLimit4 : int
    {
        kNkMAIDISOAutoHiLimit4_ISO72 = 0,
        kNkMAIDISOAutoHiLimit4_ISO80 = 1,
        kNkMAIDISOAutoHiLimit4_ISO100 = 2,
        kNkMAIDISOAutoHiLimit4_ISO125 = 3,
        kNkMAIDISOAutoHiLimit4_ISO140 = 4,
        kNkMAIDISOAutoHiLimit4_ISO160 = 5,
        kNkMAIDISOAutoHiLimit4_ISO200 = 6,
        kNkMAIDISOAutoHiLimit4_ISO250 = 7,
        kNkMAIDISOAutoHiLimit4_ISO280 = 8,
        kNkMAIDISOAutoHiLimit4_ISO320 = 9,
        kNkMAIDISOAutoHiLimit4_ISO400 = 10,
        kNkMAIDISOAutoHiLimit4_ISO500 = 11,
        kNkMAIDISOAutoHiLimit4_ISO560 = 12,
        kNkMAIDISOAutoHiLimit4_ISO640 = 13,
        kNkMAIDISOAutoHiLimit4_ISO800 = 14,
        kNkMAIDISOAutoHiLimit4_ISO1000 = 15,
        kNkMAIDISOAutoHiLimit4_ISO1100 = 16,
        kNkMAIDISOAutoHiLimit4_ISO1250 = 17,
        kNkMAIDISOAutoHiLimit4_ISO1600 = 18,
        kNkMAIDISOAutoHiLimit4_ISO2000 = 19,
        kNkMAIDISOAutoHiLimit4_ISO2200 = 20,
        kNkMAIDISOAutoHiLimit4_ISO2500 = 21,
        kNkMAIDISOAutoHiLimit4_ISO3200 = 22,
        kNkMAIDISOAutoHiLimit4_ISO4000 = 23,
        kNkMAIDISOAutoHiLimit4_ISO4500 = 24,
        kNkMAIDISOAutoHiLimit4_ISO5000 = 25,
        kNkMAIDISOAutoHiLimit4_ISO6400 = 26,
        kNkMAIDISOAutoHiLimit4_ISO8000 = 27,
        kNkMAIDISOAutoHiLimit4_ISO9000 = 28,
        kNkMAIDISOAutoHiLimit4_ISO10000 = 29,
        kNkMAIDISOAutoHiLimit4_ISO12800 = 30,
        kNkMAIDISOAutoHiLimit4_ISOHi03 = 31,
        kNkMAIDISOAutoHiLimit4_ISOHi05 = 32,
        kNkMAIDISOAutoHiLimit4_ISOHi07 = 33,
        kNkMAIDISOAutoHiLimit4_ISOHi10 = 34,
        kNkMAIDISOAutoHiLimit4_ISOHi20 = 35
    }

    public enum eNkMAIDISOAutoShutterTime : int
    {
        kNkMAIDISOAutoShutterTime_0 = 0,   // 1/125
        kNkMAIDISOAutoShutterTime_1 = 1,   // 1/60
        kNkMAIDISOAutoShutterTime_2 = 2,   // 1/30
        kNkMAIDISOAutoShutterTime_3 = 3,   // 1/15
        kNkMAIDISOAutoShutterTime_4 = 4,   // 1/8
        kNkMAIDISOAutoShutterTime_5 = 5,   // 1/4
        kNkMAIDISOAutoShutterTime_6 = 6,   // 1/2
        kNkMAIDISOAutoShutterTime_7 = 7,   // 1
        kNkMAIDISOAutoShutterTime_8 = 8,   // 2
        kNkMAIDISOAutoShutterTime_9 = 9,   // 4
        kNkMAIDISOAutoShutterTime_10 = 10, // 8
        kNkMAIDISOAutoShutterTime_11 = 11, // 15
        kNkMAIDISOAutoShutterTime_12 = 12, // 30
        kNkMAIDISOAutoShutterTime_13 = 13, // 1/250
        kNkMAIDISOAutoShutterTime_14 = 14, // 1/200
        kNkMAIDISOAutoShutterTime_15 = 15, // 1/160
        kNkMAIDISOAutoShutterTime_16 = 16, // 1/100
        kNkMAIDISOAutoShutterTime_17 = 17, // 1/80
        kNkMAIDISOAutoShutterTime_18 = 18, // 1/40
        kNkMAIDISOAutoShutterTime_19 = 19, // 1/50
        kNkMAIDISOAutoShutterTime_20 = 20, // 1/4000
        kNkMAIDISOAutoShutterTime_21 = 21, // 1/3200
        kNkMAIDISOAutoShutterTime_22 = 22, // 1/2500
        kNkMAIDISOAutoShutterTime_23 = 23, // 1/2000
        kNkMAIDISOAutoShutterTime_24 = 24, // 1/1600
        kNkMAIDISOAutoShutterTime_25 = 25, // 1/1250
        kNkMAIDISOAutoShutterTime_26 = 26, // 1/1000
        kNkMAIDISOAutoShutterTime_27 = 27, // 1/800
        kNkMAIDISOAutoShutterTime_28 = 28, // 1/640
        kNkMAIDISOAutoShutterTime_29 = 29, // 1/500
        kNkMAIDISOAutoShutterTime_30 = 30, // 1/400
        kNkMAIDISOAutoShutterTime_31 = 31, // 1/320
        kNkMAIDISOAutoShutterTime_32 = 32  // auto
    }

    public enum eNkMAIDISOAutoShutterTimeAutoValue : int
    {
        kNkMAIDISOAutoShutterTimeAutoValue_Minus2 = 0,
        kNkMAIDISOAutoShutterTimeAutoValue_Minus1 = 1,
        kNkMAIDISOAutoShutterTimeAutoValue_0 = 2,
        kNkMAIDISOAutoShutterTimeAutoValue_Plus1 = 3,
        kNkMAIDISOAutoShutterTimeAutoValue_Plus2 = 4
    }

    public enum eNkMAIDISOControlSensitivity : int
    {
        kNkMAIDISOControlSensitivity_Lo10 = 50,
        kNkMAIDISOControlSensitivity_Lo12 = 56,
        kNkMAIDISOControlSensitivity_Lo13 = 64,
        kNkMAIDISOControlSensitivity_Lo15 = 72,
        kNkMAIDISOControlSensitivity_Lo17 = 80,
        kNkMAIDISOControlSensitivity_Lo18 = 90,
        kNkMAIDISOControlSensitivity_ISO100 = 100,
        kNkMAIDISOControlSensitivity_ISO110 = 110,
        kNkMAIDISOControlSensitivity_ISO125 = 125,
        kNkMAIDISOControlSensitivity_ISO140 = 140,
        kNkMAIDISOControlSensitivity_ISO160 = 160,
        kNkMAIDISOControlSensitivity_ISO180 = 180,
        kNkMAIDISOControlSensitivity_ISO200 = 200,
        kNkMAIDISOControlSensitivity_ISO220 = 220,
        kNkMAIDISOControlSensitivity_ISO250 = 250,
        kNkMAIDISOControlSensitivity_ISO280 = 280,
        kNkMAIDISOControlSensitivity_ISO320 = 320,
        kNkMAIDISOControlSensitivity_ISO360 = 360,
        kNkMAIDISOControlSensitivity_ISO400 = 400,
        kNkMAIDISOControlSensitivity_ISO450 = 450,
        kNkMAIDISOControlSensitivity_ISO500 = 500,
        kNkMAIDISOControlSensitivity_ISO560 = 560,
        kNkMAIDISOControlSensitivity_ISO640 = 640,
        kNkMAIDISOControlSensitivity_ISO720 = 720,
        kNkMAIDISOControlSensitivity_ISO800 = 800,
        kNkMAIDISOControlSensitivity_ISO900 = 900,
        kNkMAIDISOControlSensitivity_ISO1000 = 1000,
        kNkMAIDISOControlSensitivity_ISO1100 = 1100,
        kNkMAIDISOControlSensitivity_ISO1250 = 1250,
        kNkMAIDISOControlSensitivity_ISO1400 = 1400,
        kNkMAIDISOControlSensitivity_ISO1600 = 1600,
        kNkMAIDISOControlSensitivity_ISO1800 = 1800,
        kNkMAIDISOControlSensitivity_ISO2000 = 2000,
        kNkMAIDISOControlSensitivity_ISO2200 = 2200,
        kNkMAIDISOControlSensitivity_ISO2500 = 2500,
        kNkMAIDISOControlSensitivity_ISO2800 = 2800,
        kNkMAIDISOControlSensitivity_ISO3200 = 3200,
        kNkMAIDISOControlSensitivity_ISO3600 = 3600,
        kNkMAIDISOControlSensitivity_ISO4000 = 4000,
        kNkMAIDISOControlSensitivity_ISO4500 = 4500,
        kNkMAIDISOControlSensitivity_ISO5000 = 5000,
        kNkMAIDISOControlSensitivity_ISO5600 = 5600,
        kNkMAIDISOControlSensitivity_ISO6400 = 6400,
        kNkMAIDISOControlSensitivity_ISO7200 = 7200,
        kNkMAIDISOControlSensitivity_ISO8000 = 8000,
        kNkMAIDISOControlSensitivity_ISO9000 = 9000,
        kNkMAIDISOControlSensitivity_ISO10000 = 10000,
        kNkMAIDISOControlSensitivity_ISO11000 = 11000,
        kNkMAIDISOControlSensitivity_ISO12800 = 12800,
        kNkMAIDISOControlSensitivity_Hi02 = 14400,
        kNkMAIDISOControlSensitivity_Hi03 = 16000,
        kNkMAIDISOControlSensitivity_Hi05 = 18000,
        kNkMAIDISOControlSensitivity_Hi07 = 20000,
        kNkMAIDISOControlSensitivity_Hi08 = 22000,
        kNkMAIDISOControlSensitivity_Hi10 = 25600,
        kNkMAIDISOControlSensitivity_Hi12 = 28800,
        kNkMAIDISOControlSensitivity_Hi13 = 32000,
        kNkMAIDISOControlSensitivity_Hi15 = 36000,
        kNkMAIDISOControlSensitivity_Hi17 = 40000,
        kNkMAIDISOControlSensitivity_Hi18 = 45600,
        kNkMAIDISOControlSensitivity_Hi20 = 51200,
        kNkMAIDISOControlSensitivity_Hi22 = 57600,
        kNkMAIDISOControlSensitivity_Hi23 = 64000,
        kNkMAIDISOControlSensitivity_Hi25 = 72000,
        kNkMAIDISOControlSensitivity_Hi27 = 81200,
        kNkMAIDISOControlSensitivity_Hi28 = 91200,
        kNkMAIDISOControlSensitivity_Hi30 = 102400,
        kNkMAIDISOControlSensitivity_Hi32 = 115000,
        kNkMAIDISOControlSensitivity_Hi33 = 128000,
        kNkMAIDISOControlSensitivity_Hi35 = 144000,
        kNkMAIDISOControlSensitivity_Hi37 = 162000,
        kNkMAIDISOControlSensitivity_Hi38 = 182000,
        kNkMAIDISOControlSensitivity_Hi40 = 204800
    }

    public enum eNkMAIDISOControlSensitivity2 : int
    {
        kNkMAIDISOControlSensitivity2_Lo10 = 50,
        kNkMAIDISOControlSensitivity2_Lo08 = 56,
        kNkMAIDISOControlSensitivity2_Lo07 = 64,
        kNkMAIDISOControlSensitivity2_Lo05 = 72,
        kNkMAIDISOControlSensitivity2_Lo03 = 80,
        kNkMAIDISOControlSensitivity2_Lo02 = 90,
        kNkMAIDISOControlSensitivity2_ISO100 = 100,
        kNkMAIDISOControlSensitivity2_ISO110 = 110,
        kNkMAIDISOControlSensitivity2_ISO125 = 125,
        kNkMAIDISOControlSensitivity2_ISO140 = 140,
        kNkMAIDISOControlSensitivity2_ISO160 = 160,
        kNkMAIDISOControlSensitivity2_ISO180 = 180,
        kNkMAIDISOControlSensitivity2_ISO200 = 200,
        kNkMAIDISOControlSensitivity2_ISO220 = 220,
        kNkMAIDISOControlSensitivity2_ISO250 = 250,
        kNkMAIDISOControlSensitivity2_ISO280 = 280,
        kNkMAIDISOControlSensitivity2_ISO320 = 320,
        kNkMAIDISOControlSensitivity2_ISO360 = 360,
        kNkMAIDISOControlSensitivity2_ISO400 = 400,
        kNkMAIDISOControlSensitivity2_ISO450 = 450,
        kNkMAIDISOControlSensitivity2_ISO500 = 500,
        kNkMAIDISOControlSensitivity2_ISO560 = 560,
        kNkMAIDISOControlSensitivity2_ISO640 = 640,
        kNkMAIDISOControlSensitivity2_ISO720 = 720,
        kNkMAIDISOControlSensitivity2_ISO800 = 800,
        kNkMAIDISOControlSensitivity2_ISO900 = 900,
        kNkMAIDISOControlSensitivity2_ISO1000 = 1000,
        kNkMAIDISOControlSensitivity2_ISO1100 = 1100,
        kNkMAIDISOControlSensitivity2_ISO1250 = 1250,
        kNkMAIDISOControlSensitivity2_ISO1400 = 1400,
        kNkMAIDISOControlSensitivity2_ISO1600 = 1600,
        kNkMAIDISOControlSensitivity2_ISO1800 = 1800,
        kNkMAIDISOControlSensitivity2_ISO2000 = 2000,
        kNkMAIDISOControlSensitivity2_ISO2200 = 2200,
        kNkMAIDISOControlSensitivity2_ISO2500 = 2500,
        kNkMAIDISOControlSensitivity2_ISO2800 = 2800,
        kNkMAIDISOControlSensitivity2_ISO3200 = 3200,
        kNkMAIDISOControlSensitivity2_ISO3600 = 3600,
        kNkMAIDISOControlSensitivity2_ISO4000 = 4000,
        kNkMAIDISOControlSensitivity2_ISO4500 = 4500,
        kNkMAIDISOControlSensitivity2_ISO5000 = 5000,
        kNkMAIDISOControlSensitivity2_ISO5600 = 5600,
        kNkMAIDISOControlSensitivity2_ISO6400 = 6400,
        kNkMAIDISOControlSensitivity2_ISO7200 = 7200,
        kNkMAIDISOControlSensitivity2_ISO8000 = 8000,
        kNkMAIDISOControlSensitivity2_ISO9000 = 9000,
        kNkMAIDISOControlSensitivity2_ISO10000 = 10000,
        kNkMAIDISOControlSensitivity2_ISO11000 = 11000,
        kNkMAIDISOControlSensitivity2_ISO12800 = 12800,
        kNkMAIDISOControlSensitivity2_ISO14400 = 14400,
        kNkMAIDISOControlSensitivity2_ISO16000 = 16000,
        kNkMAIDISOControlSensitivity2_ISO18000 = 18000,
        kNkMAIDISOControlSensitivity2_ISO20000 = 20000,
        kNkMAIDISOControlSensitivity2_ISO22000 = 22000,
        kNkMAIDISOControlSensitivity2_ISO25600 = 25600,
        kNkMAIDISOControlSensitivity2_Hi02 = 28800,
        kNkMAIDISOControlSensitivity2_Hi03 = 32000,
        kNkMAIDISOControlSensitivity2_Hi05 = 36000,
        kNkMAIDISOControlSensitivity2_Hi07 = 40000,
        kNkMAIDISOControlSensitivity2_Hi08 = 45600,
        kNkMAIDISOControlSensitivity2_Hi10 = 51200,
        kNkMAIDISOControlSensitivity2_Hi12 = 57600,
        kNkMAIDISOControlSensitivity2_Hi13 = 64000,
        kNkMAIDISOControlSensitivity2_Hi15 = 72000,
        kNkMAIDISOControlSensitivity2_Hi17 = 81200,
        kNkMAIDISOControlSensitivity2_Hi18 = 91200,
        kNkMAIDISOControlSensitivity2_Hi20 = 102400,
        kNkMAIDISOControlSensitivity2_Hi22 = 115000,
        kNkMAIDISOControlSensitivity2_Hi23 = 128000,
        kNkMAIDISOControlSensitivity2_Hi25 = 144000,
        kNkMAIDISOControlSensitivity2_Hi27 = 162000,
        kNkMAIDISOControlSensitivity2_Hi28 = 182000,
        kNkMAIDISOControlSensitivity2_Hi30 = 204800,
        kNkMAIDISOControlSensitivity2_Hi32 = 230000,
        kNkMAIDISOControlSensitivity2_Hi33 = 256000,
        kNkMAIDISOControlSensitivity2_Hi35 = 288000,
        kNkMAIDISOControlSensitivity2_Hi37 = 324000,
        kNkMAIDISOControlSensitivity2_Hi38 = 364000,
        kNkMAIDISOControlSensitivity2_Hi40 = 409600
    }

    public enum eNkMAIDISOControlSensitivity3 : int
    {
        kNkMAIDISOControlSensitivity3_Lo10 = 32,
        kNkMAIDISOControlSensitivity3_Lo07 = 40,
        kNkMAIDISOControlSensitivity3_Lo05 = 45,
        kNkMAIDISOControlSensitivity3_Lo03 = 56,
        kNkMAIDISOControlSensitivity3_ISO64 = 64,
        kNkMAIDISOControlSensitivity3_ISO72 = 72,
        kNkMAIDISOControlSensitivity3_ISO80 = 80,
        kNkMAIDISOControlSensitivity3_ISO100 = 100,
        kNkMAIDISOControlSensitivity3_ISO110 = 110,
        kNkMAIDISOControlSensitivity3_ISO125 = 125,
        kNkMAIDISOControlSensitivity3_ISO140 = 140,
        kNkMAIDISOControlSensitivity3_ISO160 = 160,
        kNkMAIDISOControlSensitivity3_ISO180 = 180,
        kNkMAIDISOControlSensitivity3_ISO200 = 200,
        kNkMAIDISOControlSensitivity3_ISO220 = 220,
        kNkMAIDISOControlSensitivity3_ISO250 = 250,
        kNkMAIDISOControlSensitivity3_ISO280 = 280,
        kNkMAIDISOControlSensitivity3_ISO320 = 320,
        kNkMAIDISOControlSensitivity3_ISO360 = 360,
        kNkMAIDISOControlSensitivity3_ISO400 = 400,
        kNkMAIDISOControlSensitivity3_ISO450 = 450,
        kNkMAIDISOControlSensitivity3_ISO500 = 500,
        kNkMAIDISOControlSensitivity3_ISO560 = 560,
        kNkMAIDISOControlSensitivity3_ISO640 = 640,
        kNkMAIDISOControlSensitivity3_ISO720 = 720,
        kNkMAIDISOControlSensitivity3_ISO800 = 800,
        kNkMAIDISOControlSensitivity3_ISO900 = 900,
        kNkMAIDISOControlSensitivity3_ISO1000 = 1000,
        kNkMAIDISOControlSensitivity3_ISO1100 = 1100,
        kNkMAIDISOControlSensitivity3_ISO1250 = 1250,
        kNkMAIDISOControlSensitivity3_ISO1400 = 1400,
        kNkMAIDISOControlSensitivity3_ISO1600 = 1600,
        kNkMAIDISOControlSensitivity3_ISO1800 = 1800,
        kNkMAIDISOControlSensitivity3_ISO2000 = 2000,
        kNkMAIDISOControlSensitivity3_ISO2200 = 2200,
        kNkMAIDISOControlSensitivity3_ISO2500 = 2500,
        kNkMAIDISOControlSensitivity3_ISO2800 = 2800,
        kNkMAIDISOControlSensitivity3_ISO3200 = 3200,
        kNkMAIDISOControlSensitivity3_ISO3600 = 3600,
        kNkMAIDISOControlSensitivity3_ISO4000 = 4000,
        kNkMAIDISOControlSensitivity3_ISO4500 = 4500,
        kNkMAIDISOControlSensitivity3_ISO5000 = 5000,
        kNkMAIDISOControlSensitivity3_ISO5600 = 5600,
        kNkMAIDISOControlSensitivity3_ISO6400 = 6400,
        kNkMAIDISOControlSensitivity3_ISO7200 = 7200,
        kNkMAIDISOControlSensitivity3_ISO8000 = 8000,
        kNkMAIDISOControlSensitivity3_ISO9000 = 9000,
        kNkMAIDISOControlSensitivity3_ISO10000 = 10000,
        kNkMAIDISOControlSensitivity3_ISO11000 = 11000,
        kNkMAIDISOControlSensitivity3_ISO12800 = 12800,
        kNkMAIDISOControlSensitivity3_Hi02 = 14400,
        kNkMAIDISOControlSensitivity3_Hi03 = 16000,
        kNkMAIDISOControlSensitivity3_Hi05 = 18000,
        kNkMAIDISOControlSensitivity3_Hi07 = 20000,
        kNkMAIDISOControlSensitivity3_Hi08 = 22000,
        kNkMAIDISOControlSensitivity3_Hi10 = 25600,
        kNkMAIDISOControlSensitivity3_Hi12 = 28800,
        kNkMAIDISOControlSensitivity3_Hi13 = 32000,
        kNkMAIDISOControlSensitivity3_Hi15 = 36000,
        kNkMAIDISOControlSensitivity3_Hi17 = 40000,
        kNkMAIDISOControlSensitivity3_Hi18 = 45600,
        kNkMAIDISOControlSensitivity3_Hi20 = 51200
    }

    public enum eNkMAIDJpegCompressionPolicy : int
    {
        kNkMAIDJpegCompressionPolicy_Size = 0,
        kNkMAIDJpegCompressionPolicy_Quality = 1
    }

    public enum eNkMAIDLensType : int
    {
        kNkMAIDLensType_D = 1,         // D type
        kNkMAIDLensType_G = 16,        // G type
        kNkMAIDLensType_E = 32,        // E type
        kNkMAIDLensType_VR = 256,      // VR
        kNkMAIDLensType_DX = 4096,     // DX
        kNkMAIDLensType_AFS = 65536,   // AF-S lens
        kNkMAIDLensType_AD = 1048576,  // Auto Distortion
        kNkMAIDLensType_RET = 16777216 // Retractable lens
    }

    public enum eNkMAIDLimitAFAreaMode : int
    {
        kNkMAIDLimitAFAreaMode_Dynamic9 = 2,     // Bit1
        kNkMAIDLimitAFAreaMode_Dynamic21 = 4,    // Bit2
        kNkMAIDLimitAFAreaMode_Dynamic51 = 16,   // Bit4
        kNkMAIDLimitAFAreaMode_3DTtracking = 32, // Bit5
        kNkMAIDLimitAFAreaMode_Group = 64,       // Bit6
        kNkMAIDLimitAFAreaMode_Auto = 128        // Bit7
    }

    public enum eNkMAIDLiveViewAF : int
    {
        kNkMAIDLiveViewAF_Face = 0,
        kNkMAIDLiveViewAF_Wide = 1,
        kNkMAIDLiveViewAF_Normal = 2,
        kNkMAIDLiveViewAF_SubjectTracking = 3
    }

    public enum eNkMAIDLiveViewDriveMode : int
    {
        kNkMAIDLiveViewDriveMode_Single = 0,
        kNkMAIDLiveViewDriveMode_ContinuousLow = 1,
        kNkMAIDLiveViewDriveMode_ContinuousHigh = 2
    }

    public enum eNkMAIDLiveViewExposurePreview : int
    {
        kNkMAIDLiveViewExposurePreview_Off = 0,
        kNkMAIDLiveViewExposurePreview_On = 1
    }

    public enum eNkMAIDLiveViewImageSize : int
    {
        kNkMAIDLiveViewImageSize_QVGA = 1,
        kNkMAIDLiveViewImageSize_VGA = 2
    }

    public enum eNkMAIDLiveViewImageZoomRate : int
    {
        kNkMAIDLiveViewImageZoomRate_All = 0, // Full
        kNkMAIDLiveViewImageZoomRate_25 = 1,  // 25%
        kNkMAIDLiveViewImageZoomRate_33 = 2,  // 33%
        kNkMAIDLiveViewImageZoomRate_50 = 3,  // 50%
        kNkMAIDLiveViewImageZoomRate_66 = 4,  // 66.7%
        kNkMAIDLiveViewImageZoomRate_100 = 5, // 100%
        kNkMAIDLiveViewImageZoomRate_200 = 6, // 200%
        kNkMAIDLiveViewImageZoomRate_13 = 7,  // 13%
        kNkMAIDLiveViewImageZoomRate_17 = 8   // 17%
    }

    public enum eNkMAIDLiveViewMode : int
    {
        kNkMAIDLiveViewMode_Handheld = 0,
        kNkMAIDLiveViewMode_Tripod = 1
    }

    public enum eNkMAIDLiveViewPhotoShootingMode : int
    {
        kNkMAIDLiveViewPhotoShootingMode_Quiet = 0,
        kNkMAIDLiveViewPhotoShootingMode_Silent = 1
    }

    public enum eNkMAIDLiveViewProhibit : int
    {
        kNkMAIDLiveViewProhibit_ExpModeScene = -2147483648,
        kNkMAIDLiveViewProhibit_CF = 1,
        kNkMAIDLiveViewProhibit_Sequence = 4,
        kNkMAIDLiveViewProhibit_Button = 16,
        kNkMAIDLiveViewProhibit_FEE = 32,
        kNkMAIDLiveViewProhibit_Bulb = 64,
        kNkMAIDLiveViewProhibit_Mirrorup = 128,
        kNkMAIDLiveViewProhibit_Battery = 256,
        kNkMAIDLiveViewProhibit_TTL = 512,
        kNkMAIDLiveViewProhibit_ApertureRing = 1024,
        kNkMAIDLiveViewProhibit_NonCPU = 2048,
        kNkMAIDLiveViewProhibit_SdramImg = 4096,
        kNkMAIDLiveViewProhibit_MirrorMode = 8192,
        kNkMAIDLiveViewProhibit_NoCardLock = 16384,
        kNkMAIDLiveViewProhibit_Capture = 32768,
        kNkMAIDLiveViewProhibit_EffectMode = 65536,
        kNkMAIDLiveViewProhibit_TempRise = 131072,
        kNkMAIDLiveViewProhibit_CardProtect = 262144,
        kNkMAIDLiveViewProhibit_CardError = 524288,
        kNkMAIDLiveViewProhibit_CardUnformat = 1048576,
        kNkMAIDLiveViewProhibit_BulbWarning = 2097152,
        kNkMAIDLiveViewProhibit_DuringMirrorup = 4194304,
        kNkMAIDLiveViewProhibit_DuringLiveView = 8388608,
        kNkMAIDLiveViewProhibit_Retractable = 16777216,
        kNkMAIDLiveViewProhibit_RecordingImage = 67108864
    }

    public enum eNkMAIDLiveViewScreenDispSetting : int
    {
        kNkMAIDLiveViewScreenDispSetting_ShowIndicators = 1,
        kNkMAIDLiveViewScreenDispSetting_HideIndicators = 2,
        kNkMAIDLiveViewScreenDispSetting_FramingGrid = 4,
        kNkMAIDLiveViewScreenDispSetting_ShowShootingInfo = 8,
        kNkMAIDLiveViewScreenDispSetting_ALL = 15
    }

    public enum eNkMAIDLiveViewSelector : int
    {
        kNkMAIDLiveViewSelector_Photo = 0,
        kNkMAIDLiveViewSelector_Movie = 1
    }

    public enum eNkMAIDLiveViewStatus : int
    {
        kNkMAIDLiveViewStatus_OFF = 0,
        kNkMAIDLiveViewStatus_ON = 1
    }

    public enum eNkMAIDMediaType : int
    {
        kNkMAIDMediaType_CFCard = 0,
        kNkMAIDMediaType_1394 = 1
    }

    public enum eNkMAIDMeteringMode : int
    {
        kNkMAIDMeteringMode_Matrix = 0,
        kNkMAIDMeteringMode_CenterWeighted = 1,
        kNkMAIDMeteringMode_Spot = 2,
        kNkMAIDMeteringMode_AfSpot = 3,
        kNkMAIDMeteringMode_HighLight = 4
    }

    public enum eNkMAIDMFDrive : int
    {
        kNkMAIDMFDrive_InfinityToClosest = 0,
        kNkMAIDMFDrive_ClosestToInfinity = 1
    }

    public enum eNkMAIDModuleMode : int
    {
        kNkMAIDModuleMode_Browser = 0,
        kNkMAIDModuleMode_Controller = 1
    }

    public enum eNkMAIDModuleType : int
    {
        kNkMAIDModuleType_Scanner = 1,
        kNkMAIDModuleType_Camera = 2
    }

    public enum eNkMAIDMonochromeFilterEffect : int
    {
        kNkMAIDMonochromeFilterEffect_NoBorder = 0,
        kNkMAIDMonochromeFilterEffect_Yellow = 1,
        kNkMAIDMonochromeFilterEffect_Orange = 2,
        kNkMAIDMonochromeFilterEffect_Red = 3,
        kNkMAIDMonochromeFilterEffect_Green = 4
    }

    public enum eNkMAIDMonochromeSettingType : int
    {
        kNkMAIDMonochromeSettingType_Standard = 0,
        kNkMAIDMonochromeSettingType_Custom = 1
    }

    public enum eNkMAIDMovieCCDDataMode : int
    {
        kNkMAIDMovieCCDDataMode_FXFormat = 0,
        kNkMAIDMovieCCDDataMode_DXFormat = 1
    }

    public enum eNkMAIDMovieImageQuality : int
    {
        kNkMAIDMovieImageQuality_Normal = 0,
        kNkMAIDMovieImageQuality_Fine = 1
    }

    public enum eNkMAIDMovieISOAutoHiLimit : int
    {
        kNkMAIDMovieISOAutoHiLimit_ISO400 = 0,
        kNkMAIDMovieISOAutoHiLimit_ISO500 = 1,
        kNkMAIDMovieISOAutoHiLimit_ISO560 = 2,
        kNkMAIDMovieISOAutoHiLimit_ISO640 = 3,
        kNkMAIDMovieISOAutoHiLimit_ISO800 = 4,
        kNkMAIDMovieISOAutoHiLimit_ISO1000 = 5,
        kNkMAIDMovieISOAutoHiLimit_ISO1100 = 6,
        kNkMAIDMovieISOAutoHiLimit_ISO1250 = 7,
        kNkMAIDMovieISOAutoHiLimit_ISO1600 = 8,
        kNkMAIDMovieISOAutoHiLimit_ISO2000 = 9,
        kNkMAIDMovieISOAutoHiLimit_ISO2200 = 10,
        kNkMAIDMovieISOAutoHiLimit_ISO2500 = 11,
        kNkMAIDMovieISOAutoHiLimit_ISO3200 = 12,
        kNkMAIDMovieISOAutoHiLimit_ISO4000 = 13,
        kNkMAIDMovieISOAutoHiLimit_ISO4500 = 14,
        kNkMAIDMovieISOAutoHiLimit_ISO5000 = 15,
        kNkMAIDMovieISOAutoHiLimit_ISO6400 = 16,
        kNkMAIDMovieISOAutoHiLimit_ISO8000 = 17,
        kNkMAIDMovieISOAutoHiLimit_ISO9000 = 18,
        kNkMAIDMovieISOAutoHiLimit_ISO10000 = 19,
        kNkMAIDMovieISOAutoHiLimit_ISO12800 = 20,
        kNkMAIDMovieISOAutoHiLimit_ISO16000 = 21,
        kNkMAIDMovieISOAutoHiLimit_ISO18000 = 22,
        kNkMAIDMovieISOAutoHiLimit_ISO20000 = 23,
        kNkMAIDMovieISOAutoHiLimit_ISO25600 = 24,
        kNkMAIDMovieISOAutoHiLimit_ISOHi03 = 25,
        kNkMAIDMovieISOAutoHiLimit_ISOHi05 = 26,
        kNkMAIDMovieISOAutoHiLimit_ISOHi07 = 27,
        kNkMAIDMovieISOAutoHiLimit_ISOHi10 = 28,
        kNkMAIDMovieISOAutoHiLimit_ISOHi20 = 29,
        kNkMAIDMovieISOAutoHiLimit_ISOHi30 = 30,
        kNkMAIDMovieISOAutoHiLimit_ISOHi40 = 31
    }

    public enum eNkMAIDMovieISOAutoHiLimit2 : int
    {
        kNkMAIDMovieISOAutoHiLimit2_ISO72 = 0,
        kNkMAIDMovieISOAutoHiLimit2_ISO80 = 1,
        kNkMAIDMovieISOAutoHiLimit2_ISO100 = 2,
        kNkMAIDMovieISOAutoHiLimit2_ISO125 = 3,
        kNkMAIDMovieISOAutoHiLimit2_ISO140 = 4,
        kNkMAIDMovieISOAutoHiLimit2_ISO160 = 5,
        kNkMAIDMovieISOAutoHiLimit2_ISO200 = 6,
        kNkMAIDMovieISOAutoHiLimit2_ISO250 = 7,
        kNkMAIDMovieISOAutoHiLimit2_ISO280 = 8,
        kNkMAIDMovieISOAutoHiLimit2_ISO320 = 9,
        kNkMAIDMovieISOAutoHiLimit2_ISO400 = 10,
        kNkMAIDMovieISOAutoHiLimit2_ISO500 = 11,
        kNkMAIDMovieISOAutoHiLimit2_ISO560 = 12,
        kNkMAIDMovieISOAutoHiLimit2_ISO640 = 13,
        kNkMAIDMovieISOAutoHiLimit2_ISO800 = 14,
        kNkMAIDMovieISOAutoHiLimit2_ISO1000 = 15,
        kNkMAIDMovieISOAutoHiLimit2_ISO1100 = 16,
        kNkMAIDMovieISOAutoHiLimit2_ISO1250 = 17,
        kNkMAIDMovieISOAutoHiLimit2_ISO1600 = 18,
        kNkMAIDMovieISOAutoHiLimit2_ISO2000 = 19,
        kNkMAIDMovieISOAutoHiLimit2_ISO2200 = 20,
        kNkMAIDMovieISOAutoHiLimit2_ISO2500 = 21,
        kNkMAIDMovieISOAutoHiLimit2_ISO3200 = 22,
        kNkMAIDMovieISOAutoHiLimit2_ISO4000 = 23,
        kNkMAIDMovieISOAutoHiLimit2_ISO4500 = 24,
        kNkMAIDMovieISOAutoHiLimit2_ISO5000 = 25,
        kNkMAIDMovieISOAutoHiLimit2_ISO6400 = 26,
        kNkMAIDMovieISOAutoHiLimit2_ISO8000 = 27,
        kNkMAIDMovieISOAutoHiLimit2_ISO9000 = 28,
        kNkMAIDMovieISOAutoHiLimit2_ISO10000 = 29,
        kNkMAIDMovieISOAutoHiLimit2_ISO12800 = 30,
        kNkMAIDMovieISOAutoHiLimit2_ISOHi03 = 31,
        kNkMAIDMovieISOAutoHiLimit2_ISOHi05 = 32,
        kNkMAIDMovieISOAutoHiLimit2_ISOHi07 = 33,
        kNkMAIDMovieISOAutoHiLimit2_ISOHi10 = 34,
        kNkMAIDMovieISOAutoHiLimit2_ISOHi20 = 35
    }

    public enum eNkMAIDMovieISOAutoHiLimit3 : int
    {
        kNkMAIDMovieISOAutoHiLimit3_ISO200 = 0,
        kNkMAIDMovieISOAutoHiLimit3_ISO250 = 1,
        kNkMAIDMovieISOAutoHiLimit3_ISO280 = 2,
        kNkMAIDMovieISOAutoHiLimit3_ISO320 = 3,
        kNkMAIDMovieISOAutoHiLimit3_ISO400 = 4,
        kNkMAIDMovieISOAutoHiLimit3_ISO500 = 5,
        kNkMAIDMovieISOAutoHiLimit3_ISO560 = 6,
        kNkMAIDMovieISOAutoHiLimit3_ISO640 = 7,
        kNkMAIDMovieISOAutoHiLimit3_ISO800 = 8,
        kNkMAIDMovieISOAutoHiLimit3_ISO1000 = 9,
        kNkMAIDMovieISOAutoHiLimit3_ISO1100 = 10,
        kNkMAIDMovieISOAutoHiLimit3_ISO1250 = 11,
        kNkMAIDMovieISOAutoHiLimit3_ISO1600 = 12,
        kNkMAIDMovieISOAutoHiLimit3_ISO2000 = 13,
        kNkMAIDMovieISOAutoHiLimit3_ISO2200 = 14,
        kNkMAIDMovieISOAutoHiLimit3_ISO2500 = 15,
        kNkMAIDMovieISOAutoHiLimit3_ISO3200 = 16,
        kNkMAIDMovieISOAutoHiLimit3_ISO4000 = 17,
        kNkMAIDMovieISOAutoHiLimit3_ISO4500 = 18,
        kNkMAIDMovieISOAutoHiLimit3_ISO5000 = 19,
        kNkMAIDMovieISOAutoHiLimit3_ISO6400 = 20,
        kNkMAIDMovieISOAutoHiLimit3_ISO8000 = 21,
        kNkMAIDMovieISOAutoHiLimit3_ISO9000 = 22,
        kNkMAIDMovieISOAutoHiLimit3_ISO10000 = 23,
        kNkMAIDMovieISOAutoHiLimit3_ISO12800 = 24,
        kNkMAIDMovieISOAutoHiLimit3_ISOHi03 = 25,
        kNkMAIDMovieISOAutoHiLimit3_ISOHi05 = 26,
        kNkMAIDMovieISOAutoHiLimit3_ISOHi07 = 27,
        kNkMAIDMovieISOAutoHiLimit3_ISOHi10 = 28,
        kNkMAIDMovieISOAutoHiLimit3_ISOHi20 = 29
    }

    public enum eNkMAIDMovieISORange : int
    {
        kNkMAIDMovieISORange_200to12800 = 0,
        kNkMAIDMovieISORange_200toHi40 = 1
    }

    public enum eNkMAIDMovieMeteringMode : int
    {
        kNkMAIDMovieMeteringMode_Matrix = 0,
        kNkMAIDMovieMeteringMode_CenterWeighted = 1,
        kNkMAIDMovieMeteringMode_HighLight = 2
    }

    public enum eNkMAIDMovieNoiseReductionHighISO : int
    {
        kNkMAIDMovieNoiseReductionHighISO_Off = 0,
        kNkMAIDMovieNoiseReductionHighISO_Normal = 1,
        kNkMAIDMovieNoiseReductionHighISO_High = 2,
        kNkMAIDMovieNoiseReductionHighISO_Low = 3
    }

    public enum eNkMAIDMoviePictureControl : int
    {
        kNkMAIDMoviePictureControl_Undefined = 0,
        kNkMAIDMoviePictureControl_Standard = 1,
        kNkMAIDMoviePictureControl_Neutral = 2,
        kNkMAIDMoviePictureControl_Vivid = 3,
        kNkMAIDMoviePictureControl_Monochrome = 4,
        kNkMAIDMoviePictureControl_Portrait = 5,
        kNkMAIDMoviePictureControl_Landscape = 6,
        kNkMAIDMoviePictureControl_Flat = 7,
        kNkMAIDMoviePictureControl_SamePhoto = 100,
        kNkMAIDMoviePictureControl_Option1 = 101,
        kNkMAIDMoviePictureControl_Option2 = 102,
        kNkMAIDMoviePictureControl_Option3 = 103,
        kNkMAIDMoviePictureControl_Option4 = 104,
        kNkMAIDMoviePictureControl_Custom1 = 201,
        kNkMAIDMoviePictureControl_Custom2 = 202,
        kNkMAIDMoviePictureControl_Custom3 = 203,
        kNkMAIDMoviePictureControl_Custom4 = 204,
        kNkMAIDMoviePictureControl_Custom5 = 205,
        kNkMAIDMoviePictureControl_Custom6 = 206,
        kNkMAIDMoviePictureControl_Custom7 = 207,
        kNkMAIDMoviePictureControl_Custom8 = 208,
        kNkMAIDMoviePictureControl_Custom9 = 209
    }

    public enum eNkMAIDMovieRecMicrophoneValue : int
    {
        kNkMAIDMovieRecMicrophoneValue_Off = 0,
        kNkMAIDMovieRecMicrophoneValue_1 = 1,
        kNkMAIDMovieRecMicrophoneValue_2 = 2,
        kNkMAIDMovieRecMicrophoneValue_3 = 3,
        kNkMAIDMovieRecMicrophoneValue_4 = 4,
        kNkMAIDMovieRecMicrophoneValue_5 = 5,
        kNkMAIDMovieRecMicrophoneValue_6 = 6,
        kNkMAIDMovieRecMicrophoneValue_7 = 7,
        kNkMAIDMovieRecMicrophoneValue_8 = 8,
        kNkMAIDMovieRecMicrophoneValue_9 = 9,
        kNkMAIDMovieRecMicrophoneValue_10 = 10,
        kNkMAIDMovieRecMicrophoneValue_11 = 11,
        kNkMAIDMovieRecMicrophoneValue_12 = 12,
        kNkMAIDMovieRecMicrophoneValue_13 = 13,
        kNkMAIDMovieRecMicrophoneValue_14 = 14,
        kNkMAIDMovieRecMicrophoneValue_15 = 15,
        kNkMAIDMovieRecMicrophoneValue_16 = 16,
        kNkMAIDMovieRecMicrophoneValue_17 = 17,
        kNkMAIDMovieRecMicrophoneValue_18 = 18,
        kNkMAIDMovieRecMicrophoneValue_19 = 19,
        kNkMAIDMovieRecMicrophoneValue_20 = 20
    }

    public enum eNkMAIDMovieRecordingZone : int
    {
        kNkMAIDMovieRecordingZone_WideRange = 0,
        kNkMAIDMovieRecordingZone_VocalRange = 1
    }

    public enum eNkMAIDMovieReleaseButton : int
    {
        kNkMAIDMovieReleaseButton_Photo = 0,
        kNkMAIDMovieReleaseButton_Movie = 1,
        kNkMAIDMovieReleaseButton_SaveFrame = 2
    }

    public enum eNkMAIDMovieScreenSize : int
    {
        kNkMAIDMovieScreenSize_QVGA = 0,
        kNkMAIDMovieScreenSize_VGA = 1,
        kNkMAIDMovieScreenSize_720p = 2,
        kNkMAIDMovieScreenSize_VGA_Normal = 3,
        kNkMAIDMovieScreenSize_VGA_Fine = 4,
        kNkMAIDMovieScreenSize_720p_Normal_Lowfps = 5,
        kNkMAIDMovieScreenSize_720p_Fine_Lowfps = 6,
        kNkMAIDMovieScreenSize_VGA_30fps = 7,
        kNkMAIDMovieScreenSize_720p_Normal_Highfps = 7,
        kNkMAIDMovieScreenSize_VGA_25fps = 8,
        kNkMAIDMovieScreenSize_720p_Fine_Highfps = 8,
        kNkMAIDMovieScreenSize_FullHD_Normal = 9,
        kNkMAIDMovieScreenSize_FullHD_Fine = 10,
        kNkMAIDMovieScreenSize_FullHD_Normal_Highfps = 11,
        kNkMAIDMovieScreenSize_FullHD_Fine_Highfps = 12
    }

    public enum eNkMAIDMovieScreenSize2 : int
    {
        kNkMAIDMovieScreenSize2_FullHD_30fps = 0,
        kNkMAIDMovieScreenSize2_FullHD_2 = 1,           // FullHD (1920x1080):30p/25p
        kNkMAIDMovieScreenSize2_FullHD_25fps = 1,
        kNkMAIDMovieScreenSize2_FullHD_24fps = 2,
        kNkMAIDMovieScreenSize2_720p_60fps = 3,
        kNkMAIDMovieScreenSize2_720p_50fps = 4,
        kNkMAIDMovieScreenSize2_720p_30fps = 5,
        kNkMAIDMovieScreenSize2_720p_25fps = 6,
        kNkMAIDMovieScreenSize2_FullHD_30fps_Crop = 9,
        kNkMAIDMovieScreenSize2_FullHD_25fps_Crop = 10,
        kNkMAIDMovieScreenSize2_FullHD_24fps_Crop = 11
    }

    public enum eNkMAIDMovieScreenSize3 : int
    {
        kNkMAIDMovieScreenSize3_FullHD_1 = 0, // FullHD (1920x1080):60i/50i
        kNkMAIDMovieScreenSize3_FullHD_3 = 2, // FullHD (1920x1080):24p/24p
        kNkMAIDMovieScreenSize3_720p = 3,     // 720p (1280x720):60p/50p
        kNkMAIDMovieScreenSize3_VGA = 4       // VGA  (640x424) :30p/25p
    }

    public enum eNkMAIDMovieScreenSize4 : int
    {
        kNkMAIDMovieScreenSize4_FullHD_60i = 0, // FullHD (1920x1080):60i
        kNkMAIDMovieScreenSize4_FullHD_50i = 1, // FullHD (1920x1080):50i
        kNkMAIDMovieScreenSize4_FullHD_30p = 2, // FullHD (1920x1080):30p
        kNkMAIDMovieScreenSize4_FullHD_25p = 3, // FullHD (1920x1080):25p
        kNkMAIDMovieScreenSize4_FullHD_24p = 4, // FullHD (1920x1080):24p
        kNkMAIDMovieScreenSize4_720p_60p = 5,   // 720p (1280x720):60p
        kNkMAIDMovieScreenSize4_720p_50p = 6    // 720p (1280x720):50p
    }

    public enum eNkMAIDMovieScreenSize5 : int
    {
        kNkMAIDMovieScreenSize5_FullHD_1 = 0, // FullHD (1920x1080):60p/50p
        kNkMAIDMovieScreenSize5_FullHD_2 = 1, // FullHD (1920x1080):60i/50i
        kNkMAIDMovieScreenSize5_FullHD_3 = 2, // FullHD (1920x1080):30p/25p
        kNkMAIDMovieScreenSize5_FullHD_4 = 3, // FullHD (1920x1080):24p/24p
        kNkMAIDMovieScreenSize5_720p = 4,     // 720p (1280x720):60p/50p
        kNkMAIDMovieScreenSize5_VGA = 5       // VGA  (640x424) :30p/25p
    }

    public enum eNkMAIDMovieScreenSize6 : int
    {
        kNkMAIDMovieScreenSize6_FullHD_60p = 0,       // FullHD (1920x1080):60p
        kNkMAIDMovieScreenSize6_FullHD_50p = 1,       // FullHD (1920x1080):50p
        kNkMAIDMovieScreenSize6_FullHD_30p = 2,       // FullHD (1920x1080):30p
        kNkMAIDMovieScreenSize6_FullHD_25p = 3,       // FullHD (1920x1080):25p
        kNkMAIDMovieScreenSize6_FullHD_24p = 4,       // FullHD (1920x1080):24p
        kNkMAIDMovieScreenSize6_720p_60p = 5,         // 720p (1280x720):60p
        kNkMAIDMovieScreenSize6_720p_50p = 6,         // 720p (1280x720):50p
        kNkMAIDMovieScreenSize6_VGA_30p = 7,          // VGA  (640x424) :30p
        kNkMAIDMovieScreenSize6_VGA_25p = 8,          // VGA  (640x424) :25p
        kNkMAIDMovieScreenSize6_FullHD_30p_Crop = 9,  // FullHD (1920x1080):30p Crop
        kNkMAIDMovieScreenSize6_FullHD_25p_Crop = 10, // FullHD (1920x1080):25p Crop
        kNkMAIDMovieScreenSize6_FullHD_24p_Crop = 11  // FullHD (1920x1080):24p Crop
    }

    public enum eNkMAIDMovieVoice : int
    {
        kNkMAIDMovieVoice_Off = 0,
        kNkMAIDMovieVoice_On = 1
    }

    public enum eNkMAIDMovieWBPresetProtect1 : int
    {
        kNkMAIDMovieWBPresetProtect1_Off = 0,
        kNkMAIDMovieWBPresetProtect1_On = 1
    }

    public enum eNkMAIDMovieWBPresetProtect2 : int
    {
        kNkMAIDMovieWBPresetProtect2_Off = 0,
        kNkMAIDMovieWBPresetProtect2_On = 1
    }

    public enum eNkMAIDMovieWBPresetProtect3 : int
    {
        kNkMAIDMovieWBPresetProtect3_Off = 0,
        kNkMAIDMovieWBPresetProtect3_On = 1
    }

    public enum eNkMAIDMovieWBPresetProtect4 : int
    {
        kNkMAIDMovieWBPresetProtect4_Off = 0,
        kNkMAIDMovieWBPresetProtect4_On = 1
    }

    public enum eNkMAIDMovieWBPresetProtect5 : int
    {
        kNkMAIDMovieWBPresetProtect5_Off = 0,
        kNkMAIDMovieWBPresetProtect5_On = 1
    }

    public enum eNkMAIDMovieWBPresetProtect6 : int
    {
        kNkMAIDMovieWBPresetProtect6_Off = 0,
        kNkMAIDMovieWBPresetProtect6_On = 1
    }

    public enum eNkMAIDMovieWindNoiseReduction : int
    {
        kNkMAIDMovieWindNoiseReduction_OFF = 0,
        kNkMAIDMovieWindNoiseReduction_ON = 1
    }

    public enum eNkMAIDMovManualSetting : int
    {
        kNkMAIDMovManualSetting_OFF = 0,
        kNkMAIDMovManualSetting_ON = 1
    }

    public enum eNkMAIDMovRecDestination : int
    {
        kNkMAIDMovRecDestination_CF = 0,
        kNkMAIDMovRecDestination_SD = 1,
        kNkMAIDMovRecDestination_XQD = 2
    }

    public enum eNkMAIDMovRecDestination2 : int
    {
        kNkMAIDMovRecDestination2_Slot1 = 0,
        kNkMAIDMovRecDestination2_Slot2 = 1
    }

    public enum eNkMAIDMovRecHiISO : int
    {
        kNkMAIDMovRecHiISO_Off = 0,
        kNkMAIDMovRecHiISO_On = 1
    }

    public enum eNkMAIDMovRecInCardProhibit : int
    {
        kNkMAIDMovRecInCardProhibit_NoCard = 1,
        kNkMAIDMovRecInCardProhibit_CardErr = 2,
        kNkMAIDMovRecInCardProhibit_NoFormat = 4,
        kNkMAIDMovRecInCardProhibit_CardFull = 8,
        kNkMAIDMovRecInCardProhibit_CardInBuf = 128,
        kNkMAIDMovRecInCardProhibit_PCInBuf = 256,
        kNkMAIDMovRecInCardProhibit_MovInBuf = 512,
        kNkMAIDMovRecInCardProhibit_RecMov = 1024,
        kNkMAIDMovRecInCardProhibit_CardProtect = 2048,
        kNkMAIDMovRecInCardProhibit_LVImageZoom = 4096,
        kNkMAIDMovRecInCardProhibit_LVPhoto = 8192
    }

    public enum eNkMAIDMovRecInCardStatus : int
    {
        kNkMAIDMovRecInCardStatus_Off = 0,
        kNkMAIDMovRecInCardStatus_On = 1
    }

    public enum eNkMAIDMovRecMicrophone : int
    {
        kNkMAIDMovRecMicrophone_Auto = 0,
        kNkMAIDMovRecMicrophone_High = 1,
        kNkMAIDMovRecMicrophone_Medium = 2,
        kNkMAIDMovRecMicrophone_Low = 3,
        kNkMAIDMovRecMicrophone_Off = 4,
        kNkMAIDMovRecMicrophone_Manual = 5
    }

    public enum eNkMAIDNegativeScanMode : int
    {
        kNkMAIDNegativeScanMode_Original = 0, // The original method of Nikon is used.
        kNkMAIDNegativeScanMode_NoProcess = 1
    }

    public enum eNkMAIDNoiseReductionHighISO : int
    {
        kNkMAIDNoiseReductionHighISO_Off = 0,
        kNkMAIDNoiseReductionHighISO_Normal = 1,
        kNkMAIDNoiseReductionHighISO_High = 2,
        kNkMAIDNoiseReductionHighISO_Low = 3
    }

    public enum eNkMAIDObjectType : int
    {
        kNkMAIDObjectType_Module = 1,
        kNkMAIDObjectType_Source = 2,
        kNkMAIDObjectType_Item = 3,
        kNkMAIDObjectType_DataObj = 4
    }

    public enum eNkMAIDPictureControl : int
    {
        kNkMAIDPictureControl_Undefined = 0,
        kNkMAIDPictureControl_Standard = 1,
        kNkMAIDPictureControl_Neutral = 2,
        kNkMAIDPictureControl_Vivid = 3,
        kNkMAIDPictureControl_Monochrome = 4,
        kNkMAIDPictureControl_Portrait = 5,
        kNkMAIDPictureControl_Landscape = 6,
        kNkMAIDPictureControl_Flat = 7,
        kNkMAIDPictureControl_Option1 = 101,
        kNkMAIDPictureControl_Option2 = 102,
        kNkMAIDPictureControl_Option3 = 103,
        kNkMAIDPictureControl_Option4 = 104,
        kNkMAIDPictureControl_Custom1 = 201,
        kNkMAIDPictureControl_Custom2 = 202,
        kNkMAIDPictureControl_Custom3 = 203,
        kNkMAIDPictureControl_Custom4 = 204,
        kNkMAIDPictureControl_Custom5 = 205,
        kNkMAIDPictureControl_Custom6 = 206,
        kNkMAIDPictureControl_Custom7 = 207,
        kNkMAIDPictureControl_Custom8 = 208,
        kNkMAIDPictureControl_Custom9 = 209
    }

    public enum eNkMAIDPrimarySlot : int
    {
        kNkMAIDPrimarySlot_CF = 0,
        kNkMAIDPrimarySlot_SD = 1,
        kNkMAIDPrimarySlot_XQD = 2
    }

    public enum eNkMAIDPrimarySlot2 : int
    {
        kNkMAIDPrimarySlot2_Slot1 = 0,
        kNkMAIDPrimarySlot2_Slot2 = 1
    }

    public enum eNkMAIDRangeFinderSetting : int
    {
        kNkMAIDRangeFinderSetting_Off = 0, // OFF
        kNkMAIDRangeFinderSetting_On = 1   // ON
    }

    public enum eNkMAIDRangeFinderStatus : int
    {
        kNkMAIDRangeFinderStatus_OutOfFocus = 0,  // out of focus
        kNkMAIDRangeFinderStatus_FrontFocusL = 1, // in front of the subject(large distance)
        kNkMAIDRangeFinderStatus_FrontFocusS = 2, // in front of the subject (small distance)
        kNkMAIDRangeFinderStatus_InFocus = 3,     // In focus
        kNkMAIDRangeFinderStatus_RearFocusS = 4,  // behind the subject (small distance)
        kNkMAIDRangeFinderStatus_RearFocusL = 5   // behind the subject (large distance)
    }

    public enum eNkMAIDRawJpegImageStatus : int
    {
        kNkMAIDRawJpegImageStatus_Single = 0,
        kNkMAIDRawJpegImageStatus_RawJpeg = 1
    }

    public enum eNkMAIDRemoteControlMode : int
    {
        kNkMAIDRemoteControlMode_Delayed = 0,
        kNkMAIDRemoteControlMode_QuickResponse = 1,
        kNkMAIDRemoteControlMode_MirrorUp = 2,
        kNkMAIDRemoteControlMode_Off = 3
    }

    public enum eNkMAIDRemoteTimer : int
    {
        kNkMAIDRemoteTimer_1min = 0,
        kNkMAIDRemoteTimer_5min = 1,
        kNkMAIDRemoteTimer_10min = 2,
        kNkMAIDRemoteTimer_15min = 3
    }

    public enum eNkMAIDResult : int
    {
        kNkMAIDResult_NotSupported = -127,
        kNkMAIDResult_UnexpectedDataType = -126,
        kNkMAIDResult_ValueOutOfBounds = -125,
        kNkMAIDResult_BufferSize = -124,
        kNkMAIDResult_Aborted = -123,
        kNkMAIDResult_NoMedia = -122,
        kNkMAIDResult_NoEventProc = -121,
        kNkMAIDResult_NoDataProc = -120,
        kNkMAIDResult_ZombieObject = -119,
        kNkMAIDResult_OutOfMemory = -118,
        kNkMAIDResult_UnexpectedError = -117,
        kNkMAIDResult_HardwareError = -116,
        kNkMAIDResult_MissingComponent = -115,
        kNkMAIDResult_NoError = 0,                 // these values are warnings
        kNkMAIDResult_Pending = 1,
        kNkMAIDResult_OrphanedChildren = 2,
        kNkMAIDResult_VendorBase = 127,
        kNkMAIDResult_ApertureFEE = 128,           // = 128
        kNkMAIDResult_BufferNotReady = 129,
        kNkMAIDResult_NormalTTL = 130,
        kNkMAIDResult_MediaFull = 131,
        kNkMAIDResult_InvalidMedia = 132,
        kNkMAIDResult_EraseFailure = 133,
        kNkMAIDResult_CameraNotFound = 134,
        kNkMAIDResult_BatteryDontWork = 135,
        kNkMAIDResult_ShutterBulb = 136,
        kNkMAIDResult_OutOfFocus = 137,
        kNkMAIDResult_Protected = 138,
        kNkMAIDResult_FileExists = 139,
        kNkMAIDResult_SharingViolation = 140,
        kNkMAIDResult_DataTransFailure = 141,
        kNkMAIDResult_SessionFailure = 142,
        kNkMAIDResult_FileRemoved = 143,
        kNkMAIDResult_BusReset = 144,
        kNkMAIDResult_NonCPULens = 145,
        kNkMAIDResult_ReleaseButtonPressed = 146,
        kNkMAIDResult_BatteryExhausted = 147,
        kNkMAIDResult_CaptureFailure = 148,
        kNkMAIDResult_InvalidString = 149,
        kNkMAIDResult_NotInitialized = 150,
        kNkMAIDResult_CaptureDisable = 151,
        kNkMAIDResult_DeviceBusy = 152,
        kNkMAIDResult_CaptureDustFailure = 153,
        kNkMAIDResult_ICADown = 154,
        kNkMAIDResult_CpxPlaybackMode = 158,
        kNkMAIDResult_NotLiveView = 159,
        kNkMAIDResult_MFDriveEnd = 160,
        kNkMAIDResult_UnformattedMedia = 161,
        kNkMAIDResult_MediaReadOnly = 162,
        kNkMAIDResult_DuringUpdate = 163,
        kNkMAIDResult_BulbReleaseBusy = 164,
        kNkMAIDResult_SilentReleaseBusy = 165,
        kNkMAIDResult_MovieFrameReleaseBusy = 166,
        kNkMAIDResult_ShutterTime = 167,
        kNkMAIDResult_AutoFocusFailed = 385,       // From Nikon Scan 3.1
        kNkMAIDResult_NoFilm = 386,                // From Nikon Scan 3.1
        kNkMAIDResult_NoAction = 639               // From Nikon Scan 3.1
    }

    public enum eNkMAIDReverseState : int
    {
        kNkMAIDReverseState_None = 0,       // It is not reversed.
        kNkMAIDReverseState_Horizontal = 1, // It is horizontally reversed.
        kNkMAIDReverseState_Vertical = 2,   // It is vertically reversed.
        kNkMAIDReverseState_Both = 3        // It is horizontally and vertically reversed.
    }

    public enum eNkMAIDSaturationSetting : int
    {
        kNkMAIDSaturationSetting_Normal = 0,
        kNkMAIDSaturationSetting_Low = 1,
        kNkMAIDSaturationSetting_High = 2,
        kNkMAIDSaturationSetting_Auto = 3
    }

    public enum eNkMAIDSaveMedia : int
    {
        kNkMAIDSaveMedia_Card = 0,
        kNkMAIDSaveMedia_SDRAM = 1,
        kNkMAIDSaveMedia_Card_SDRAM = 2
    }

    public enum eNkMAIDSceneMode : int
    {
        kNkMAIDSceneMode_NightLandscape = 0,
        kNkMAIDSceneMode_PartyIndoor = 1,
        kNkMAIDSceneMode_BeachSnow = 2,
        kNkMAIDSceneMode_Sunset = 3,
        kNkMAIDSceneMode_Duskdawn = 4,
        kNkMAIDSceneMode_Petportrait = 5,
        kNkMAIDSceneMode_Candlelight = 6,
        kNkMAIDSceneMode_Blossom = 7,
        kNkMAIDSceneMode_AutumnColors = 8,
        kNkMAIDSceneMode_Food = 9,
        kNkMAIDSceneMode_Silhouette = 10,
        kNkMAIDSceneMode_Highkey = 11,
        kNkMAIDSceneMode_Lowkey = 12,
        kNkMAIDSceneMode_Portrait = 13,
        kNkMAIDSceneMode_Landscape = 14,
        kNkMAIDSceneMode_Child = 15,
        kNkMAIDSceneMode_Sports = 16,
        kNkMAIDSceneMode_Closeup = 17,
        kNkMAIDSceneMode_NightPortrait = 18
    }

    public enum eNkMAIDScreenTips : int
    {
        kNkMAIDScreenTips_On = 0,
        kNkMAIDScreenTips_Off = 1
    }

    public enum eNkMAIDSelfTimerShootNum : int
    {
        kNkMAIDSelfTimerShootNum_1 = 0,
        kNkMAIDSelfTimerShootNum_2 = 1,
        kNkMAIDSelfTimerShootNum_3 = 2,
        kNkMAIDSelfTimerShootNum_4 = 3,
        kNkMAIDSelfTimerShootNum_5 = 4,
        kNkMAIDSelfTimerShootNum_6 = 5,
        kNkMAIDSelfTimerShootNum_7 = 6,
        kNkMAIDSelfTimerShootNum_8 = 7,
        kNkMAIDSelfTimerShootNum_9 = 8
    }

    public enum eNkMAIDShootingMode : int
    {
        kNkMAIDShootingMode_S = 0,
        kNkMAIDShootingMode_C = 1,
        kNkMAIDShootingMode_CH = 2,
        kNkMAIDShootingMode_SelfTimer = 3,
        kNkMAIDShootingMode_MirrorUp = 4,
        kNkMAIDShootingMode_RemoteTimer_Instant = 5,
        kNkMAIDShootingMode_RemoteTimer_2sec = 6,
        kNkMAIDShootingMode_LiveView = 7,
        kNkMAIDShootingMode_Quiet = 8,
        kNkMAIDShootingMode_RemoteCtrl = 9,
        kNkMAIDShootingMode_QuietC = 10,
        kNkMAIDShootingMode_Unknown = 255
    }

    public enum eNkMAIDShutterSpeedLockSetting : int
    {
        kNkMAIDShutterSpeedLockSetting_Off = 0,
        kNkMAIDShutterSpeedLockSetting_On = 1
    }

    public enum eNkMAIDSlot2ImageSaveMode : int
    {
        kNkMAIDSlot2ImageSaveMode_Overflow = 0,
        kNkMAIDSlot2ImageSaveMode_Backup = 1,
        kNkMAIDSlot2ImageSaveMode_Jpeg = 2
    }

    public enum eNkMAIDSpotWBMode : int
    {
        kNkMAIDSpotWBMode_OFF = 0,
        kNkMAIDSpotWBMode_ON = 1
    }

    public enum eNkMAIDTypicalFlashMode : int
    {
        kNkMAIDTypicalFlashMode_Auto = 0,
        kNkMAIDTypicalFlashMode_ForcedOn = 1,
        kNkMAIDTypicalFlashMode_Off = 2,
        kNkMAIDTypicalFlashMode_RedEyeReduction = 3,
        kNkMAIDTypicalFlashMode_SlowSync = 4
    }

    public enum eNkMAIDUIRequestResult : int
    {
        kNkMAIDUIRequestResult_None = 0,
        kNkMAIDUIRequestResult_Ok = 1,
        kNkMAIDUIRequestResult_Cancel = 2,
        kNkMAIDUIRequestResult_Yes = 3,
        kNkMAIDUIRequestResult_No = 4
    }

    public enum eNkMAIDUIRequestType : int
    {
        kNkMAIDUIRequestType_Ok = 0,
        kNkMAIDUIRequestType_OkCancel = 1,
        kNkMAIDUIRequestType_YesNo = 2,
        kNkMAIDUIRequestType_YesNoCancel = 3
    }

    public enum eNkMAIDUSBSpeed : int
    {
        kNkMAIDUSBSpeed_FullSpeed = 0,
        kNkMAIDUSBSpeed_HighSpeed = 1,
        kNkMAIDUSBSpeed_SuperSpeed = 2
    }

    public enum eNkMAIDUserMode : int
    {
        kNkMAIDUserMode_NightLandscape = 0,
        kNkMAIDUserMode_PartyIndoor = 1,
        kNkMAIDUserMode_BeachSnow = 2,
        kNkMAIDUserMode_Sunset = 3,
        kNkMAIDUserMode_Duskdawn = 4,
        kNkMAIDUserMode_Petportrait = 5,
        kNkMAIDUserMode_Candlelight = 6,
        kNkMAIDUserMode_Blossom = 7,
        kNkMAIDUserMode_AutumnColors = 8,
        kNkMAIDUserMode_Food = 9,
        kNkMAIDUserMode_Silhouette = 10,
        kNkMAIDUserMode_Highkey = 11,
        kNkMAIDUserMode_Lowkey = 12,
        kNkMAIDUserMode_Portrait = 13,
        kNkMAIDUserMode_Landscape = 14,
        kNkMAIDUserMode_Child = 15,
        kNkMAIDUserMode_Sports = 16,
        kNkMAIDUserMode_Closeup = 17,
        kNkMAIDUserMode_NightPortrait = 18,
        kNkMAIDUserMode_Program = 19,
        kNkMAIDUserMode_SpeedPriority = 20,
        kNkMAIDUserMode_AperturePriority = 21,
        kNkMAIDUserMode_Manual = 22,
        kNkMAIDUserMode_Auto = 23,
        kNkMAIDUserMode_FlashOff = 24,
        kNkMAIDUserMode_NightVision = 25,
        kNkMAIDUserMode_ColorSketch = 26,
        kNkMAIDUserMode_Miniature = 27,
        kNkMAIDUserMode_SelectColor = 28
    }

    public enum eNkMAIDVideoMode : int
    {
        kNkMAIDVideoMode_NTSC = 0,
        kNkMAIDVideoMode_PAL = 1
    }

    public enum eNkMAIDVignetteControl : int
    {
        kNkMAIDVignetteControl_High = 0,
        kNkMAIDVignetteControl_Normal = 1,
        kNkMAIDVignetteControl_Low = 2,
        kNkMAIDVignetteControl_Off = 3
    }

    public enum eNkMAIDWarningDisp : int
    {
        kNkMAIDWarningDisp_On = 0,
        kNkMAIDWarningDisp_Off = 1
    }

    public enum eNkMAIDWBBracketingStep : int
    {
        kNkMAIDWBBracketingStep_1STEP = 0,
        kNkMAIDWBBracketingStep_2STEP = 1,
        kNkMAIDWBBracketingStep_3STEP = 2
    }

    public enum eNkMAIDWBPresetProtect1 : int
    {
        kNkMAIDWBPresetProtect1_Off = 0,
        kNkMAIDWBPresetProtect1_On = 1
    }

    public enum eNkMAIDWBPresetProtect2 : int
    {
        kNkMAIDWBPresetProtect2_Off = 0,
        kNkMAIDWBPresetProtect2_On = 1
    }

    public enum eNkMAIDWBPresetProtect3 : int
    {
        kNkMAIDWBPresetProtect3_Off = 0,
        kNkMAIDWBPresetProtect3_On = 1
    }

    public enum eNkMAIDWBPresetProtect4 : int
    {
        kNkMAIDWBPresetProtect4_Off = 0,
        kNkMAIDWBPresetProtect4_On = 1
    }

    public enum eNkMAIDWBPresetProtect5 : int
    {
        kNkMAIDWBPresetProtect5_Off = 0,
        kNkMAIDWBPresetProtect5_On = 1
    }

    public enum eNkMAIDWBPresetProtect6 : int
    {
        kNkMAIDWBPresetProtect6_Off = 0,
        kNkMAIDWBPresetProtect6_On = 1
    }

    public enum eNkMAIDWBTuneColorTemp : int
    {
        kNkMAIDWBTuneColorTemp_Unknown = 0,
        kNkMAIDWBTuneColorTemp_2500 = 2500,
        kNkMAIDWBTuneColorTemp_2550 = 2550,
        kNkMAIDWBTuneColorTemp_2560 = 2560,
        kNkMAIDWBTuneColorTemp_2630 = 2630,
        kNkMAIDWBTuneColorTemp_2650 = 2650,
        kNkMAIDWBTuneColorTemp_2700 = 2700,
        kNkMAIDWBTuneColorTemp_2780 = 2780,
        kNkMAIDWBTuneColorTemp_2800 = 2800,
        kNkMAIDWBTuneColorTemp_2850 = 2850,
        kNkMAIDWBTuneColorTemp_2860 = 2860,
        kNkMAIDWBTuneColorTemp_2940 = 2940,
        kNkMAIDWBTuneColorTemp_2950 = 2950,
        kNkMAIDWBTuneColorTemp_3000 = 3000,
        kNkMAIDWBTuneColorTemp_3030 = 3030,
        kNkMAIDWBTuneColorTemp_3100 = 3100,
        kNkMAIDWBTuneColorTemp_3130 = 3130,
        kNkMAIDWBTuneColorTemp_3200 = 3200,
        kNkMAIDWBTuneColorTemp_3230 = 3230,
        kNkMAIDWBTuneColorTemp_3300 = 3300,
        kNkMAIDWBTuneColorTemp_3330 = 3330,
        kNkMAIDWBTuneColorTemp_3400 = 3400,
        kNkMAIDWBTuneColorTemp_3450 = 3450,
        kNkMAIDWBTuneColorTemp_3570 = 3570,
        kNkMAIDWBTuneColorTemp_3600 = 3600,
        kNkMAIDWBTuneColorTemp_3700 = 3700,
        kNkMAIDWBTuneColorTemp_3800 = 3800,
        kNkMAIDWBTuneColorTemp_3850 = 3850,
        kNkMAIDWBTuneColorTemp_4000 = 4000,
        kNkMAIDWBTuneColorTemp_4170 = 4170,
        kNkMAIDWBTuneColorTemp_4200 = 4200,
        kNkMAIDWBTuneColorTemp_4300 = 4300,
        kNkMAIDWBTuneColorTemp_4350 = 4350,
        kNkMAIDWBTuneColorTemp_4500 = 4500,
        kNkMAIDWBTuneColorTemp_4550 = 4550,
        kNkMAIDWBTuneColorTemp_4760 = 4760,
        kNkMAIDWBTuneColorTemp_4800 = 4800,
        kNkMAIDWBTuneColorTemp_5000 = 5000,
        kNkMAIDWBTuneColorTemp_5260 = 5260,
        kNkMAIDWBTuneColorTemp_5300 = 5300,
        kNkMAIDWBTuneColorTemp_5560 = 5560,
        kNkMAIDWBTuneColorTemp_5600 = 5600,
        kNkMAIDWBTuneColorTemp_5880 = 5880,
        kNkMAIDWBTuneColorTemp_5900 = 5900,
        kNkMAIDWBTuneColorTemp_6250 = 6250,
        kNkMAIDWBTuneColorTemp_6300 = 6300,
        kNkMAIDWBTuneColorTemp_6670 = 6670,
        kNkMAIDWBTuneColorTemp_6700 = 6700,
        kNkMAIDWBTuneColorTemp_7100 = 7100,
        kNkMAIDWBTuneColorTemp_7140 = 7140,
        kNkMAIDWBTuneColorTemp_7690 = 7690,
        kNkMAIDWBTuneColorTemp_7700 = 7700,
        kNkMAIDWBTuneColorTemp_8300 = 8300,
        kNkMAIDWBTuneColorTemp_8330 = 8330,
        kNkMAIDWBTuneColorTemp_9090 = 9090,
        kNkMAIDWBTuneColorTemp_9100 = 9100,
        kNkMAIDWBTuneColorTemp_9900 = 9900,
        kNkMAIDWBTuneColorTemp_10000 = 10000
    }

    public enum eNkMovieWBAutoType : int
    {
        kNkMovieWBAutoType_Normal = 0,
        kNkMovieWBAutoType_WarmWhite = 1
    }

    public enum eNkMovieWBFluorescentType : int
    {
        kNkMovieWBFluorescentType_SodiumVapor = 0,
        kNkMovieWBFluorescentType_WarmWhite = 1,
        kNkMovieWBFluorescentType_White = 2,
        kNkMovieWBFluorescentType_CoolWhite = 3,
        kNkMovieWBFluorescentType_DayWhite = 4,
        kNkMovieWBFluorescentType_Daylight = 5,
        kNkMovieWBFluorescentType_HiTempMercuryVapor = 6
    }

    public enum eNkWBAutoType : int
    {
        kNkWBAutoType_Normal = 0,
        kNkWBAutoType_WarmWhite = 1
    }

    public enum eNkWBFluorescentType : int
    {
        kNkWBFluorescentType_SodiumVapor = 0,
        kNkWBFluorescentType_WarmWhite = 1,
        kNkWBFluorescentType_White = 2,
        kNkWBFluorescentType_CoolWhite = 3,
        kNkWBFluorescentType_DayWhite = 4,
        kNkWBFluorescentType_Daylight = 5,
        kNkWBFluorescentType_HiTempMercuryVapor = 6
    }
}
