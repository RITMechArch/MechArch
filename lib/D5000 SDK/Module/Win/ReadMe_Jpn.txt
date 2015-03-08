Nikon Type0003 Module SDK Revision.1 概要


■用途
 カメラのコントロールを行う。


■サポートするカメラ
 D90,D5000


■動作環境・制限事項
 [Windows]
    Windows XP Home Edition (SP3) / Professional (SP3)
    Windows Vista SP1 32bit版の各エディション
    (Home Basic / Home Premium / Business / Enterprise / Ultimate)
    ※カメラ本体の通信モード(セットアップメニュー/USB)をPTPに設定して下さい。
      カメラがMass Storageに設定されていると、Windowsからコントロールするこ
      とはできません。

 [Macintosh]
    MacOS X 10.4.11
    MacOS X 10.5.5
    ※カメラ本体の通信モード(セットアップメニュー/USB)をPTPに設定して下さい。
      カメラがMass Storageに設定されていると、Macintoshからコントロールするこ
      とはできません。


■内容物
 [Windows]
    Documents
      MAID3(J).pdf : 基本インターフェース仕様
      MAID3Type0003(J).pdf : Type0003 Moduleで使用される
                                                  拡張インターフェース仕様
      Usage of Type0003 Module(J).pdf : Type0003 Module を使用する上での
                                                                  注意事項
      Type0003 Sample Guide(J).pdf : サンプルプログラムの使用方法

    Binary Files(Win)
      WinXP_Vista
        Type0003.md3 : Windows用 Type0003 Module本体
        NkdPTP.dll : Windows XP, Vista用　PTPドライバ
 
    Header Files
      Maid3.h : MAIDインターフェース基本ヘッダ
      Maid3d1.h : Type0003用MAIDインターフェース拡張ヘッダ
      NkTypes.h : 上記ヘッダで使用する型の定義

    Sample Program
      Type0003CtrlSample(Win) : Microsoft Visual Studio .Net 2003 用
                                                              プロジェクト

 [Macintosh]
    Documents
      MAID3(J).pdf : 基本インターフェース仕様
      MAID3Type0003(J).pdf : Type0003 Moduleで使用される
                                                    拡張インターフェース仕様
      Usage of Type0003 Module(J).pdf : Type0003 Module を使用する上での
                                                                    注意事項
      Type0003 Sample Guide(J).pdf : サンプルプログラムの使用方法

    Binary Files(Mac)
        Type0003 Module.bundle : Macintosh用 Type0003 Module本体 
                                                            (Universal Binary)
        libNkPTPDriver.dylib : Macintosh用 PTP ドライバ (Universal Binary)
 
    Header Files
      Maid3.h : MAIDインターフェース基本ヘッダ
      Maid3d1.h : Type0003用MAIDインターフェース拡張ヘッダ
      NkTypes.h : 上記ヘッダで使用する型の定義

    Sample Program
      Type0003CtrlSample(Mac) : Xcode 2.5用のサンプルプログラムプロジェクト
                                (Universal Binary)


■制限事項
 本Module SDKを利用してコントロールできるカメラは1台のみです。
 複数台のコントロールには対応していません。
