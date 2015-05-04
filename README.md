# Xamarin-Freshdesk-Android
Simple Integration of freshdesk to xamarin Android

In order to integrate FreshDesk, you'll need to follow these steps:

1) Copy the fresh desk dll from here: 
https://github.com/IdoTene/Xamarin-Freshdesk-Android/blob/master/mobihelp_sdk_android_v1.3.1.dll

2) Add to your manifest file these activities, services and receivers:

      <uses-permission android:name="android.permission.INTERNET" />
      <uses-permission android:name="android.permission.READ_LOGS" />
      <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
      <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
    
    
      <application android:label="FreshDeskAndroidSample" android:icon="@drawable/Icon">
    
        <activity
              android:name="com.freshdesk.mobihelp.activity.SolutionArticleListActivity"
              android:configChanges="orientation|screenSize"
              android:theme="@style/Theme.Mobihelp"
              android:windowSoftInputMode="adjustPan" >
        </activity>
        <activity
            android:name="com.freshdesk.mobihelp.activity.FeedbackActivity"
            android:configChanges="keyboardHidden|orientation|screenSize"
            android:theme="@style/Theme.Mobihelp"
            android:windowSoftInputMode="adjustResize|stateVisible" >
        </activity>
        <activity
            android:name="com.freshdesk.mobihelp.activity.TicketListActivity"
            android:parentActivityName="com.freshdesk.mobihelp.activity.SolutionArticleListActivity"
            android:theme="@style/Theme.Mobihelp" >
    
          <!-- Parent activity meta-data to support 4.0 and lower -->
          <meta-data
              android:name="android.support.PARENT_ACTIVITY"
              android:value="com.freshdesk.mobihelp.activity.SolutionArticleListActivity" />
        </activity>
        <activity
            android:name="com.freshdesk.mobihelp.activity.SolutionArticleActivity"
            android:parentActivityName="com.freshdesk.mobihelp.activity.SolutionArticleListActivity"
            android:theme="@style/Theme.Mobihelp"
            android:configChanges="orientation|screenSize|keyboard|keyboardHidden" >
    
          <!-- Parent activity meta-data to support 4.0 and lower -->
          <meta-data
              android:name="android.support.PARENT_ACTIVITY"
              android:value="com.freshdesk.mobihelp.activity.SolutionArticleListActivity" />
        </activity>
        <activity
            android:name="com.freshdesk.mobihelp.activity.ConversationActivity"
            android:parentActivityName="com.freshdesk.mobihelp.activity.SolutionArticleListActivity"
            android:theme="@style/Theme.Mobihelp"
            android:windowSoftInputMode="adjustResize|stateHidden" >
    
          <!-- Parent activity meta-data to support 4.0 and lower -->
          <meta-data
              android:name="android.support.PARENT_ACTIVITY"
              android:value="com.freshdesk.mobihelp.activity.SolutionArticleListActivity" />
        </activity>
        <activity
            android:name="com.freshdesk.mobihelp.activity.AttachmentHandlerActivity"
            android:configChanges="keyboardHidden|orientation|screenSize"
            android:parentActivityName="com.freshdesk.mobihelp.activity.SolutionArticleListActivity"
            android:theme="@style/Theme.Mobihelp" >
    
          <!-- Parent activity meta-data to support 4.0 and lower -->
          <meta-data
              android:name="android.support.PARENT_ACTIVITY"
              android:value="com.freshdesk.mobihelp.activity.SolutionArticleListActivity" />
        </activity>
        
        <service android:name="com.freshdesk.mobihelp.service.MobihelpService" />
    
        <receiver android:name="com.freshdesk.mobihelp.receiver.ConnectivityReceiver" >
          <intent-filter>
            <action android:name="android.net.conn.CONNECTIVITY_CHANGE" />
          </intent-filter>
        </receiver>
        
      </application>
  
  3) Make sure you have Android Support Library v7 AppCompat component from the xamarin store 
  
  Once you have done all these steps, you can use this code to load Fresh desk screen:
  
            var config = new MobihelpConfig(
                "http://your-domain.freshdesk.com",
            "m1-1-*************************",
            "*******************************");

            Mobihelp.Init(this, config);


           Mobihelp.ShowSupport(this);
