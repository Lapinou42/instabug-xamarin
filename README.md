##Instabug for Xamarin
You can use Instabug native SDK as a Binding library in your solution, following is how to:
- Integrate Instabug in your Android project.
- Integrate Instabug in your iOS project.

##How to integrate Instabug in your Xamarin Android Application.
1. Add existing Instabug-Android-SDK to your solution.
![1](https://cloud.githubusercontent.com/assets/14965412/14788342/b6114468-0b07-11e6-8c59-486545cb703f.png)
2. Add required depencies as a references to InstabugAndroidSDK.
  - android support version 4
  - android support version 7 appcompat
  - google play services maps
  - google play service GCM
![2](https://cloud.githubusercontent.com/assets/14965412/14788341/b610bf70-0b07-11e6-8d92-3f8ac257e03c.png)

3. Add Instabug-Android-SDK as a reference to your Android project.
![3](https://cloud.githubusercontent.com/assets/14965412/14788343/b61563b8-0b07-11e6-9823-c87e2b1847fe.png)

4. Add required depencies as a references to your Android Project.
  - android support version 4
  - android support version 7 appcompat
  - google play services maps
  - google play service GCM

![4](https://cloud.githubusercontent.com/assets/14965412/14788344/b61ab7e6-0b07-11e6-933b-c0a4635d0f63.png)

5. Re build your project, Start  Use Instabug.
![5](https://cloud.githubusercontent.com/assets/14965412/14788345/b61ed632-0b07-11e6-8a05-905fb7320a54.png)



## How to integrate Instabug in Xamarin iOS Application
1. **Add Instabug binding project to your project solution (Say MyApplication)**
After downloading the project (InstabugIOSSDK), right click on solution name and select Add > Add Existing Project, navigate to downloaded project and select it "InstabugIOSSDK.csproj".
![Add Project](https://cloud.githubusercontent.com/assets/14965412/14787321/396a02fa-0b03-11e6-955f-d2da8b9ee40f.png)
![Select Instabug](https://cloud.githubusercontent.com/assets/14965412/14787322/396b71e4-0b03-11e6-8f61-28e0c1e9c584.png)

2. **Link Instabug to your project.** Now we need to link Instabug to our application. So we are going to edit MyApplication project References and from "All" check InstabugIOSSDK.
![References](https://cloud.githubusercontent.com/assets/14965412/14787323/396f511a-0b03-11e6-992a-45aae0c53cca.png)
![iOSSDK](https://cloud.githubusercontent.com/assets/14965412/14787324/3973bbc4-0b03-11e6-8c98-af11e1044330.png)

3. **Add Instabug dependencies to MyApplication.** Instabug needs some iOS frameworks to build. We are going to add them. Right click on your project name and select "Options". From left tabs select "Build" > "iOS Build". Now Copy following and paste in `Additional mtouch arguments` field.
```
-gcc_flags="-framework CoreGraphics -framework AVFoundation -framework CoreMotion -framework CoreTelephony -framework SystemConfiguration -framework MessageUI -framework MobileCoreServices -framework AudioToolbox -framework QuartzCore -framework CoreLocation -framework CoreGraphics -framework CoreVideo -framework CoreMedia -lstdc++"
```
![iOS Build](https://cloud.githubusercontent.com/assets/14965412/14787326/397b0398-0b03-11e6-9e2f-e696cdc11120.png)
![iOS Build](https://cloud.githubusercontent.com/assets/14965412/14787325/39788f78-0b03-11e6-9dd1-bc4b25832319.png)

***Important***
*You have to add additional flags for all build configurations Degub/Release iPhone/Simulator*
![Important](https://cloud.githubusercontent.com/assets/14965412/14787327/398c0972-0b03-11e6-9dd6-c629a98e29ad.png)

4. **Build InstabugIOSSDK project.**
![Build Binding Project](https://cloud.githubusercontent.com/assets/14965412/14787328/3996062a-0b03-11e6-867d-5d978cc198ec.png)

5. **Now you are ready to use Instabug in your project.**
![Use Instabug](https://cloud.githubusercontent.com/assets/14965412/14787757/304d35f0-0b05-11e6-94ba-e61636db0a0b.png)

**voilà**
![file16](https://cloud.githubusercontent.com/assets/14965412/14787330/399f9c80-0b03-11e6-82c3-3b0039484075.png)
