# Accelerating your Android Emulator with GenyMotion or HAXM

Out of the box, the Google Android Emulators are prohibitively slow, to the point of being near unusable. As such, several technologies are available to significantly speed them up so that they can be used effectively. Two of the most popular of these technologies are:

 * **GenyMotion** - Genymotion provides a virtual Android environment built on top of VirtualBox, a generic x86 hardware virtualization system. A version is available free for personal use. Advanced features are available in the Indie and Business licenses.
 * **Intel HAXM Drivers** - The Intel HAXM Drivers provide hardware acceleration for x86 based emulators on Intel VT-enabled sytems. The HAXM drivers are free to use and published by Intel. 

## Setting Up GenyMotion as Your Android Emulator

1. To get started, [download VirtualBox](http://www.oracle.com/technetwork/server-storage/virtualbox/downloads/index.html) and run the installer.

2. Follow through the instructions presented by the VirtualBox installer. Please note, on Windows, it will disrupt your network connection while it installs network drivers. On Mac OS X, you will want to restart after installing VirtualBox before proceeding.

3. [Register at Genymotion](https://cloud.genymotion.com/page/customer/login/) and [download the appropriate installer](https://cloud.genymotion.com/page/launchpad/download/) for your platform.

4. On OS X, mount the .dmg download and install Genymotion by dragging Genymotion and the Genymotion Shell to your application directory. On Windows, run the installer and proceed through the dialogs.

5. Run Genymotion and log in with your Genymotion account to access the list of pre-configured devices. Pick your desired Android version or device and start downloading the device image.

6. After you have a device downloaded and ready, click the Play icon. Depending on your system, the virtual device will boot up in a few seconds. _NOTE: Genymotion currently offers only one KitKat (Android 4.4) device, a 10-inch tablet. If you are deploying to a device running an earlier Android version, you will need to make sure to adjust the Minimum Android version accordingly in your project (Project properties > Android Application)._

7. From Xamarin Studio, deploy your project and pick the Genymotion emulator as the target.

## Setting Up Your Google Android Emulator with the Intel Hardware Accelerated Execution Manager (HAXM)


1. Launch Xamarin Studio.

2. From the Tools menu, choose Android SDK Manager.

3. In the SDK Manager, make sure you have installed the x86 Atom System Image for the desired Android SDK version. If needed, select it and install the package, agreeing to the license as needed. The image will download and install. At this point, you can build x86 Android Virtual Device versions by selecting the appropriate CPU/ABI choice when creating the device, but they will not be accelerated. If you have any Android Virtual Devices running, close them before continuing.

4. From the Intel website, [download the latest HAXM virtualization engine](http://software.intel.com/en-us/articles/intel-hardware-accelerated-execution-manager/). _If you are running Mac OS X 10.9 Mavericks or Windows 8.1, you will want the appropriate hotfix version that corrects issues on these systems. While the links appear to have been temporarily removed, they are still accessible directly from the original links: [HAXM hotfix for OS X 10.9](http://software.intel.com/en-us/articles/intel-hardware-accelerated-execution-manager-end-user-license-agreement-macos-hotfix) and [HAXM hotfix for Windows 8.1](http://software.intel.com/en-us/articles/intel-hardware-accelerated-execution-manager-end-user-license-agreement-windows-hotfix)._

5. Install the HAXM engine, following along with the dialogs.

6. If you haven't already created an x86 Android Virtual Device, do so now from the Android Virtual Device Manager (accessible in Xamarin Studio from the Tools menu by selecting Open Android Emulator Manager).

7. After you have a device defined, in the Virtual Device Manager, select it and click Start. Adjust any launch options and Launch it. After several seconds, your accelerated Android Virtual Device will be running.

8. From Xamarin Studio, deploy your project and pick your new x86 emulator device as the target.

NOTE: HAXM run simultaneously with VirtualBox can cause stability issues. Both can exist together on the same machine, but it is best not to run both Genymotion- and HAXM-based emulators at the same time.