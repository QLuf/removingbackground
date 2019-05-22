
1. Create Record file
	- Record in Microsoft Kinect Studio
	- Record File saved Document/Kinect Studio/Repository
2. Create Sample Action file .gbd in Visual Gesture Builder

	- File -> New Solution -> TestHand.vgbsln
	- Click name file -> Create New Project Wizard -> create name action ,ex Hand -->Hand_Left and Hand_Right
	- Add clip -> recorded clip in the explorer of VGB in Repository
	- Shift + left and right arrow -> group select key frames until you reach a point where you want the gesture to end -> press enter. 
		A blue line is shown where the gesture is selected. By default all frames are false and have no line and you don’t need to set every other frame to false.
	(Or you can type "true" in the upper right corner)
	-  Right click the database ->Build. 
	- Add other clip in Hand_Left.a or Hand_Right.a -> click Analyze ->ou will be able to see the confidence of the Gesture and whether it is marked as true or false
	- Make sure your Kinect is plugged in -> File -> Live Preview and select your .gdb file ->Test
	
	https://channel9.msdn.com/Blogs/raw-tech/Making-your-body-the-controller-Kinect-Tutorial-for-Unity
	http://kinect.github.io/tutorial/lab12/index.html
	https://channel9.msdn.com/Blogs/raw-tech/Making-your-body-the-controller-Kinect-Tutorial-for-Unity

3. Green Scence
	- Download "KinectForWindows_UnityPro_2.0.1410" 
	- Use unitypackage and example
	- Open GreenScence Shader in Material: 
	Change //Texture2D _MainTex;
			-> UNITY_DECLARE_TEX2D(_MainTex);
		//o = _MainTex.Sample(SampleType, i.tex);
			-> o = UNITY_SAMPLE_TEX2D(_MainTex, i.tex);
	Add: SubShader {
		Blend SrcAlpha OneMinusSrcAlpha
		Tags{ "Queue" = "AlphaTest" }
with: o = float4(0, 1, 0, 0); (R,G,B,alpha) alpha=0 blend

4. Use Camera2D for background, with Depth than min MainCamera's Depth
	Note: Camera2D only see name Layer and Culling mask of Background, MainCamere not see background Layer