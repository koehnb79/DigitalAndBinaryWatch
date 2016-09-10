S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 23656
Date: 2016-06-12 18:33:04-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1a6

Register Information
r0   = 0x0000019a, r1   = 0x0000000d
r2   = 0x0000000a, r3   = 0xb5b22194
r4   = 0x0000019a, r5   = 0x00000000
r6   = 0xb9025584, r7   = 0xb9017008
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6f64dc0
ip   = 0xbea6dc7c, sp   = 0xbea6dc30
lr   = 0xb6f4a0d0, pc   = 0xb6f499dc
cpsr = 0x20000010

Memory Information
MemTotal:   391348 KB
MemFree:     42016 KB
Buffers:      3576 KB
Cached:      80420 KB
VmPeak:      73060 KB
VmSize:      72516 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14240 KB
VmRSS:       14240 KB
VmData:      21136 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 23656 TID = 23656
23656 23743 23749 

Maps Information
b2c13000 b3412000 rwxp [stack:23749]
b34ad000 b34c4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b34d1000 b3558000 rw-s anon_inode:dmabuf
b3558000 b3563000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b356c000 b356e000 r-xp /usr/lib/libgenlock.so
b3581000 b3584000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b358d000 b3d8c000 rwxp [stack:23743]
b3f8c000 b3f93000 r-xp /usr/lib/libtbm.so.1.0.0
b3f9b000 b3f9d000 r-xp /usr/lib/libdri2.so.0.0.0
b3fa5000 b3faa000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fb2000 b3fba000 r-xp /usr/lib/libdrm.so.2.4.0
b3fc2000 b3fcb000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3fd4000 b3fe0000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fe8000 b3ff1000 r-xp /usr/lib/libcom-core.so.0.0.1
b5581000 b5587000 r-xp /usr/lib/libwidget.so.1.0.0
b5590000 b5596000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b559e000 b5682000 r-xp /usr/lib/libicuuc.so.51.1
b5697000 b57d4000 r-xp /usr/lib/libicui18n.so.51.1
b57e4000 b57f1000 r-xp /usr/lib/libalarm.so.0.0.0
b57fa000 b5801000 r-xp /usr/lib/libappcore-watch.so.1.1
b59a9000 b59b3000 r-xp /lib/libnss_files-2.13.so
b59bc000 b5a8b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5aa1000 b5ac5000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ace000 b5ad4000 r-xp /usr/lib/libappsvc.so.0.1.0
b5adc000 b5ade000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5ae7000 b5aeb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5afd000 b5b02000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b0a000 b5b0c000 r-xp /usr/lib/libiniparser.so.0
b5b15000 b5b1a000 r-xp /usr/lib/libappcore-common.so.1.1
b5b22000 b5b24000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5b2c000 b5b30000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b3d000 b5b3f000 r-xp /usr/lib/libXau.so.6.0.0
b5b48000 b5b4f000 r-xp /lib/libcrypt-2.13.so
b5b7f000 b5b81000 r-xp /usr/lib/libiri.so
b5b89000 b5d31000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d4a000 b5d97000 r-xp /usr/lib/libssl.so.1.0.0
b5da4000 b5dd2000 r-xp /usr/lib/libidn.so.11.5.44
b5dda000 b5de3000 r-xp /usr/lib/libcares.so.2.1.0
b5dec000 b5dff000 r-xp /usr/lib/libxcb.so.1.1.0
b5e08000 b5e0a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e13000 b5e15000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e1e000 b5eea000 r-xp /usr/lib/libxml2.so.2.7.8
b5ef7000 b5ef9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f01000 b5f06000 r-xp /usr/lib/libffi.so.5.0.10
b5f0e000 b5f0f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f18000 b5f23000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f2b000 b5f2e000 r-xp /lib/libattr.so.1.1.0
b5f36000 b5fca000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fdd000 b5ffa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6003000 b601b000 r-xp /usr/lib/libpng12.so.0.50.0
b6024000 b603a000 r-xp /lib/libexpat.so.1.5.2
b6044000 b6088000 r-xp /usr/lib/libcurl.so.4.3.0
b6091000 b609b000 r-xp /usr/lib/libXext.so.6.4.0
b60a4000 b60a8000 r-xp /usr/lib/libXtst.so.6.1.0
b60b0000 b60b6000 r-xp /usr/lib/libXrender.so.1.3.0
b60bf000 b60c5000 r-xp /usr/lib/libXrandr.so.2.2.0
b60cd000 b60ce000 r-xp /usr/lib/libXinerama.so.1.0.0
b60d7000 b60e0000 r-xp /usr/lib/libXi.so.6.1.0
b60e8000 b60eb000 r-xp /usr/lib/libXfixes.so.3.1.0
b60f3000 b60f5000 r-xp /usr/lib/libXgesture.so.7.0.0
b60fd000 b60ff000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6108000 b610a000 r-xp /usr/lib/libXdamage.so.1.1.0
b6112000 b6119000 r-xp /usr/lib/libXcursor.so.1.0.2
b6121000 b6124000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b612c000 b6130000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6139000 b613e000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6148000 b6229000 r-xp /usr/lib/libX11.so.6.3.0
b6234000 b6257000 r-xp /usr/lib/libjpeg.so.8.0.2
b626f000 b6285000 r-xp /lib/libz.so.1.2.5
b628d000 b6302000 r-xp /usr/lib/libsqlite3.so.0.8.6
b630c000 b6322000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b632b000 b635f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6368000 b643b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6446000 b6456000 r-xp /lib/libresolv-2.13.so
b645a000 b64d6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64e2000 b64fa000 r-xp /usr/lib/liblzma.so.5.0.3
b6503000 b6506000 r-xp /lib/libcap.so.2.21
b650e000 b653b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6543000 b6544000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b654c000 b6552000 r-xp /usr/lib/libecore_imf.so.1.7.99
b655a000 b6571000 r-xp /usr/lib/liblua-5.1.so
b657b000 b6582000 r-xp /usr/lib/libembryo.so.1.7.99
b658a000 b6590000 r-xp /lib/librt-2.13.so
b6599000 b65ef000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65fc000 b6652000 r-xp /usr/lib/libfreetype.so.6.11.3
b665e000 b6686000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6688000 b66c5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66ce000 b66e1000 r-xp /usr/lib/libfribidi.so.0.3.1
b66e9000 b6703000 r-xp /usr/lib/libecore_con.so.1.7.99
b670c000 b6715000 r-xp /usr/lib/libedbus.so.1.7.99
b671d000 b676d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6770000 b6774000 r-xp /usr/lib/libvconf.so.0.2.45
b677c000 b678d000 r-xp /usr/lib/libecore_input.so.1.7.99
b6795000 b679a000 r-xp /usr/lib/libecore_file.so.1.7.99
b67a2000 b67c4000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67cd000 b680e000 r-xp /usr/lib/libeina.so.1.7.99
b6817000 b6830000 r-xp /usr/lib/libeet.so.1.7.99
b6841000 b68aa000 r-xp /lib/libm-2.13.so
b68b3000 b68b9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68c2000 b68c5000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68cd000 b68ef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68f7000 b68fc000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6904000 b692e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6937000 b694e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6956000 b6961000 r-xp /lib/libunwind.so.8.0.1
b698e000 b69ca000 r-xp /usr/lib/libsystemd.so.0.4.0
b69d3000 b6aee000 r-xp /lib/libc-2.13.so
b6afc000 b6b04000 r-xp /lib/libgcc_s-4.6.so.1
b6b05000 b6b08000 r-xp /usr/lib/libsmack.so.1.0.0
b6b10000 b6b16000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b1e000 b6bee000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6bef000 b6c4c000 r-xp /usr/lib/libedje.so.1.7.99
b6c56000 b6c6d000 r-xp /usr/lib/libecore.so.1.7.99
b6c84000 b6d52000 r-xp /usr/lib/libevas.so.1.7.99
b6d77000 b6eb2000 r-xp /usr/lib/libelementary.so.1.7.99
b6ec8000 b6edc000 r-xp /lib/libpthread-2.13.so
b6ee7000 b6ee9000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef1000 b6ef4000 r-xp /usr/lib/libbundle.so.0.1.22
b6efc000 b6efe000 r-xp /lib/libdl-2.13.so
b6f07000 b6f13000 r-xp /usr/lib/libaul.so.0.1.0
b6f25000 b6f2a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f33000 b6f37000 r-xp /usr/lib/libsys-assert.so
b6f40000 b6f5d000 r-xp /lib/ld-2.13.so
b6f66000 b6f6b000 r-xp /usr/bin/launchpad-loader
b8f25000 b90bb000 rw-p [heap]
bea4e000 bea6f000 rwxp [stack]
bea4e000 bea6f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:23656)
Call Stack Count: 6
 0: (0xb6f499dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6f4a0d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6f4a360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6f4e5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6f54a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb6a4070c) [/lib/libc.so.6] + 0x6d70c
End of Call Stack

Package Information
Package Name: org.example.decimalwatch
Package ID : org.example.decimalwatch
Version: 1.0.0
Package Type: rpm
App Name: decimalwatch
App ID: org.example.decimalwatch
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
er_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
06-12 18:32:55.749-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-12 18:32:55.749-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-12 18:32:55.749-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 1[0;m
06-12 18:32:55.749-0500 I/HIGEAR  ( 1551): WakeupService.cpp: WakeupServiceStart(395) > [svoice:Application:WakeupServiceStart:IN]
06-12 18:32:55.819-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
06-12 18:32:55.819-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
06-12 18:32:55.819-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:32:55.829-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
06-12 18:32:55.829-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:32:55.849-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:32:55.929-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
06-12 18:32:55.929-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_enable(133) > 0
06-12 18:32:56.229-0500 E/PKGMGR  (23850): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 18:32:56.349-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: main(2131) > package manager server start
06-12 18:32:56.469-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_822371109], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_822371109' '-r' 'org.example.decimalwatch'], cookie=[BPEbKx6oqpFV6XU/nchjmp9dgxE=], backend_flag=[0]
06-12 18:32:56.469-0500 E/PKGMGR  (23852): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 18:32:56.469-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 18:32:56.479-0500 E/PKGMGR_SERVER(23853): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 18:32:56.479-0500 E/PKGMGR  (23850): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[238500002]
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:32:56.729-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.739-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:32:56.739-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [true][0m
06-12 18:32:56.749-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:32:56.769-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:32:56.769-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:32:56.779-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1166
06-12 18:32:56.789-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 18:32:56.789-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 18:32:56.799-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:32:56.799-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 18:32:56.809-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.809-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:32:56.819-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.819-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:32:56.819-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:32:56.819-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.829-0500 W/W_HOME  ( 1166): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-12 18:32:56.829-0500 E/W_HOME  ( 1166): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-12 18:32:56.829-0500 I/TIZEN_N_SOUND_MANAGER( 1592): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-12 18:32:56.829-0500 W/TIZEN_N_SOUND_MANAGER( 1592): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:32:56.829-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:32:56.949-0500 W/CERT_SVC(23853): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
06-12 18:32:56.989-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-12 18:32:56.999-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:32:56.999-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 131
06-12 18:32:56.999-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 131
06-12 18:32:56.999-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 54 1
06-12 18:32:56.999-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 55 1
06-12 18:32:56.999-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 56 1
06-12 18:32:56.999-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 57 1
06-12 18:32:57.019-0500 E/PKGMGR_CERT(23853): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-12 18:32:57.219-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23753
06-12 18:32:57.329-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23629
06-12 18:32:57.369-0500 E/EFL     (23855): elementary<23855> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 18:32:57.379-0500 E/EFL     (23855): elementary<23855> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 18:32:57.399-0500 E/EFL     (23855): elementary<23855> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 18:32:57.399-0500 E/EFL     (23855): elementary<23855> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 18:32:57.429-0500 E/EFL     (23855): elementary<23855> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 18:32:57.429-0500 E/EFL     (23855): elementary<23855> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 18:32:57.429-0500 E/EFL     (23855): elementary<23855> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 18:32:57.429-0500 E/EFL     (23855): elementary<23855> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 18:32:57.429-0500 E/EFL     (23855): elementary<23855> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 18:32:57.449-0500 E/EFL     (23855): elementary<23855> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 18:32:57.449-0500 E/EFL     (23855): elementary<23855> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 18:32:57.449-0500 E/EFL     (23855): elementary<23855> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 18:32:57.479-0500 E/EFL     (23855): elementary<23855> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 18:32:57.479-0500 E/EFL     (23855): elementary<23855> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 18:32:57.479-0500 E/EFL     (23855): elementary<23855> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 18:32:57.489-0500 E/EFL     (23855): elementary<23855> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 18:32:57.489-0500 E/EFL     (23855): elementary<23855> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 18:32:57.489-0500 E/EFL     (23855): elementary<23855> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 18:32:57.489-0500 E/EFL     (23855): elementary<23855> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 18:32:57.489-0500 I/AUL_PAD (23855): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 18:32:57.789-0500 I/efl-extension(23856): efl_extension.c: eext_mod_init(40) > Init
06-12 18:32:57.819-0500 E/EFL     (23856): elementary<23856> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 18:32:57.819-0500 E/EFL     (23856): elementary<23856> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 18:32:57.839-0500 E/EFL     (23856): elementary<23856> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 18:32:57.839-0500 I/UXT     (23856): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
06-12 18:32:57.839-0500 E/EFL     (23856): elementary<23856> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 18:32:57.869-0500 E/EFL     (23856): elementary<23856> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 18:32:57.869-0500 E/EFL     (23856): elementary<23856> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 18:32:57.869-0500 E/EFL     (23856): elementary<23856> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 18:32:57.869-0500 E/EFL     (23856): elementary<23856> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 18:32:57.869-0500 E/EFL     (23856): elementary<23856> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 18:32:57.889-0500 E/EFL     (23856): elementary<23856> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 18:32:57.889-0500 E/EFL     (23856): elementary<23856> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 18:32:57.889-0500 E/EFL     (23856): elementary<23856> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 18:32:57.919-0500 E/EFL     (23856): elementary<23856> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 18:32:57.919-0500 I/AUL_PAD (23856): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): OpenGL ES Shader Compiler Version: E031.24.00.16
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): Build Date: 09/02/15 Wed
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): Local Branch: 
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): Remote Branch: 
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): Local Patches: 
06-12 18:32:58.059-0500 I/Adreno-EGL(23856): Reconstruct Branch: 
06-12 18:32:58.209-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23855
06-12 18:32:58.309-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:32:59.769-0500 E/rpm-installer(23853): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
06-12 18:33:00.309-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:33:01.929-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:33:02.179-0500 W/WATCH_CORE(23656): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
06-12 18:33:02.179-0500 I/WATCH_CORE(23656): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
06-12 18:33:02.189-0500 W/W_HOME  ( 1166): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-12 18:33:02.189-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:33:02.189-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_enable(133) > 1
06-12 18:33:02.189-0500 W/W_HOME  ( 1166): event_manager.c: _lcd_off_cb(699) > lcd state: 0
06-12 18:33:02.189-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:02.189-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
06-12 18:33:02.189-0500 W/STARTER ( 1103): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
06-12 18:33:02.199-0500 E/STARTER ( 1103): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
06-12 18:33:02.199-0500 W/STARTER ( 1103): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
06-12 18:33:02.199-0500 W/STARTER ( 1103): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
06-12 18:33:02.199-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(963) > [0;32mINFO: LCDOff receive data : -1226765556[0;m
06-12 18:33:02.199-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(964) > [0;32mINFO: WakeupServiceStop[0;m
06-12 18:33:02.199-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStop(401) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-12 18:33:02.199-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
06-12 18:33:02.219-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-12 18:33:02.219-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-12 18:33:02.219-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 0[0;m
06-12 18:33:02.219-0500 I/HIGEAR  ( 1551): WakeupService.cpp: WakeupServiceStop(405) > [svoice:Application:WakeupServiceStop:IN]
06-12 18:33:02.309-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 18:33:02.529-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
06-12 18:33:02.529-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
06-12 18:33:02.529-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
06-12 18:33:02.529-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
06-12 18:33:02.529-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: PAUSE State: RUNNING
06-12 18:33:02.529-0500 I/CAPI_APPFW_APPLICATION( 1166): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 18:33:02.529-0500 W/W_HOME  ( 1166): main.c: _appcore_pause_cb(692) > appcore pause
06-12 18:33:02.529-0500 W/W_HOME  ( 1166): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
06-12 18:33:02.529-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:02.529-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:02.529-0500 W/W_HOME  ( 1166): main.c: home_pause(762) > clock/widget paused
06-12 18:33:02.529-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:33:02.529-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:33:02.529-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 18:33:02.529-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
06-12 18:33:02.529-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:33:02.529-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
06-12 18:33:02.529-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:33:02.529-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [false][0m
06-12 18:33:02.529-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 18:33:02.539-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 18:33:03.029-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: MEM_FLUSH State: PAUSED
06-12 18:33:03.629-0500 W/WATCH_CORE(23656): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
06-12 18:33:03.629-0500 I/WATCH_CORE(23656): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
06-12 18:33:03.629-0500 W/wnotibp (13988): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_set(161) > timer set
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): gesture.c: _apps_status_get(123) > apps status:0
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:1412
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_schedule(211) > schedule, manual render
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): event_manager.c: _lcd_on_cb(691) > lcd state: 1
06-12 18:33:03.629-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:03.629-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [powerkey] after screen off time [1412]ms
06-12 18:33:03.629-0500 W/STARTER ( 1103): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:33:03.639-0500 I/APP_CORE( 1166): appcore-efl.c: __do_app(429) > [APP 1166] Event: RESUME State: PAUSED
06-12 18:33:03.639-0500 I/CAPI_APPFW_APPLICATION( 1166): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): main.c: _appcore_resume_cb(683) > appcore resume
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): main.c: home_resume(735) > clock/widget resumed
06-12 18:33:03.639-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 18:33:03.639-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 18:33:03.639-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(954) > [0;32mINFO: LCDOn receive data : -1226765556[0;m
06-12 18:33:03.639-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: OnReceiveDisplayChanged(955) > [0;32mINFO: WakeupServiceStart[0;m
06-12 18:33:03.639-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStart(371) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-12 18:33:03.639-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
06-12 18:33:03.649-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-12 18:33:03.649-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupServiceStart(390) > [0;32mINFO: 500[0;m
06-12 18:33:03.649-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
06-12 18:33:03.649-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-12 18:33:03.649-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
06-12 18:33:03.659-0500 I/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-12 18:33:03.659-0500 W/TIZEN_N_SOUND_MANAGER( 1551): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-12 18:33:03.659-0500 W/WAKEUP-SERVICE( 1551): WakeupService.cpp: WakeupSetSeamlessValue(364) > [0;32mINFO: WAKEUP SET : 1[0;m
06-12 18:33:03.659-0500 I/HIGEAR  ( 1551): WakeupService.cpp: WakeupServiceStart(395) > [svoice:Application:WakeupServiceStart:IN]
06-12 18:33:03.769-0500 W/STARTER ( 1103): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [powerkey]
06-12 18:33:03.769-0500 W/STARTER ( 1103): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
06-12 18:33:03.829-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
06-12 18:33:03.829-0500 W/W_HOME  ( 1166): gesture.c: _manual_render_enable(133) > 0
06-12 18:33:03.849-0500 I/SHealth_Common( 1630): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
06-12 18:33:03.849-0500 I/SHealth_Service( 1630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-12 18:33:03.849-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : pedometer_inactive_period error
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_10min_precaution_millisec error
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-12 18:33:03.899-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1630): preference.c: preference_get_double(1214) > preference_get_double(1630) : inactive_before_10min_precaution_millisec error
06-12 18:33:04.169-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: sighandler(409) > child NORMAL exit [23853]
06-12 18:33:04.189-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 18:33:04.289-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.decimalwatch is updated, need to check validation
06-12 18:33:04.289-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.example.decimalwatch
06-12 18:33:04.309-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 18:33:04.309-0500 E/PKGMGR_SERVER(23852): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 18:33:04.319-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, COMPLETED]
06-12 18:33:04.319-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6915) > package install complete
06-12 18:33:04.319-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_package_install_event(4787) > 
06-12 18:33:04.319-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
06-12 18:33:04.359-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(249) > clock org.example.decimalwatch is updated, preload:0 update:0 event->update:0
06-12 18:33:04.409-0500 E/APPS    ( 1166): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
06-12 18:33:04.419-0500 E/PKGMGR_INFO(  891): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-12 18:33:04.429-0500 E/STARTER ( 1103): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
06-12 18:33:04.629-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 4
06-12 18:33:04.629-0500 E/AUL_AMD (  926): amd_request.c: __app_process_by_pid(193) > pid(23656) is dead. cmd(4) is canceled
06-12 18:33:04.629-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 0
06-12 18:33:04.639-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:33:04.649-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 18:33:04.649-0500 E/AUL_AMD (  926): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
06-12 18:33:04.649-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(1708) > caller pid : 1122
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 18:33:04.659-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 18:33:04.659-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 18:33:04.659-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.w-home]register msg port [true][0m
06-12 18:33:04.669-0500 W/CRASH_MANAGER(23866): worker.c: worker_job(1199) > 1123656646563146577438
