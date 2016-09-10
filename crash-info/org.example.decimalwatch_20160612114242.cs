S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.0
Build-Number: R730VVRU1BPC1
Build-Date: 2016.03.18 12:05:08

Crash Information
Process Name: decimalwatch
PID: 10980
Date: 2016-06-12 11:42:42-0500
Executable File Path: /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x19e

Register Information
r0   = 0x00000192, r1   = 0x0000000d
r2   = 0x00000002, r3   = 0xb5abf194
r4   = 0x00000192, r5   = 0x00000000
r6   = 0xb8b8c354, r7   = 0xb8b7de08
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6f01dc0
ip   = 0xbe956c7c, sp   = 0xbe956c30
lr   = 0xb6ee70d0, pc   = 0xb6ee69dc
cpsr = 0x20000010

Memory Information
MemTotal:   391348 KB
MemFree:     24252 KB
Buffers:      3768 KB
Cached:      70832 KB
VmPeak:      73204 KB
VmSize:      72660 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14492 KB
VmRSS:       14492 KB
VmData:      21280 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20516 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10980 TID = 10980
10980 11208 11215 

Maps Information
b2bb0000 b33af000 rwxp [stack:11215]
b344a000 b3461000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b346e000 b34f5000 rw-s anon_inode:dmabuf
b34f5000 b3500000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3509000 b350b000 r-xp /usr/lib/libgenlock.so
b351e000 b3521000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b352a000 b3d29000 rwxp [stack:11208]
b3f29000 b3f30000 r-xp /usr/lib/libtbm.so.1.0.0
b3f38000 b3f3a000 r-xp /usr/lib/libdri2.so.0.0.0
b3f42000 b3f47000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f4f000 b3f57000 r-xp /usr/lib/libdrm.so.2.4.0
b3f5f000 b3f68000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3f71000 b3f7d000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3f85000 b3f8e000 r-xp /usr/lib/libcom-core.so.0.0.1
b551e000 b5524000 r-xp /usr/lib/libwidget.so.1.0.0
b552d000 b5533000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b553b000 b561f000 r-xp /usr/lib/libicuuc.so.51.1
b5634000 b5771000 r-xp /usr/lib/libicui18n.so.51.1
b5781000 b578e000 r-xp /usr/lib/libalarm.so.0.0.0
b5797000 b579e000 r-xp /usr/lib/libappcore-watch.so.1.1
b5946000 b5950000 r-xp /lib/libnss_files-2.13.so
b5959000 b5a28000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a3e000 b5a62000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5a6b000 b5a71000 r-xp /usr/lib/libappsvc.so.0.1.0
b5a79000 b5a7b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5a84000 b5a88000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5a9a000 b5a9f000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5aa7000 b5aa9000 r-xp /usr/lib/libiniparser.so.0
b5ab2000 b5ab7000 r-xp /usr/lib/libappcore-common.so.1.1
b5abf000 b5ac1000 r-xp /opt/usr/apps/org.example.decimalwatch/bin/decimalwatch
b5ac9000 b5acd000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5ada000 b5adc000 r-xp /usr/lib/libXau.so.6.0.0
b5ae5000 b5aec000 r-xp /lib/libcrypt-2.13.so
b5b1c000 b5b1e000 r-xp /usr/lib/libiri.so
b5b26000 b5cce000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ce7000 b5d34000 r-xp /usr/lib/libssl.so.1.0.0
b5d41000 b5d6f000 r-xp /usr/lib/libidn.so.11.5.44
b5d77000 b5d80000 r-xp /usr/lib/libcares.so.2.1.0
b5d89000 b5d9c000 r-xp /usr/lib/libxcb.so.1.1.0
b5da5000 b5da7000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5db0000 b5db2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5dbb000 b5e87000 r-xp /usr/lib/libxml2.so.2.7.8
b5e94000 b5e96000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5e9e000 b5ea3000 r-xp /usr/lib/libffi.so.5.0.10
b5eab000 b5eac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5eb5000 b5ec0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5ec8000 b5ecb000 r-xp /lib/libattr.so.1.1.0
b5ed3000 b5f67000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f7a000 b5f97000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5fa0000 b5fb8000 r-xp /usr/lib/libpng12.so.0.50.0
b5fc1000 b5fd7000 r-xp /lib/libexpat.so.1.5.2
b5fe1000 b6025000 r-xp /usr/lib/libcurl.so.4.3.0
b602e000 b6038000 r-xp /usr/lib/libXext.so.6.4.0
b6041000 b6045000 r-xp /usr/lib/libXtst.so.6.1.0
b604d000 b6053000 r-xp /usr/lib/libXrender.so.1.3.0
b605c000 b6062000 r-xp /usr/lib/libXrandr.so.2.2.0
b606a000 b606b000 r-xp /usr/lib/libXinerama.so.1.0.0
b6074000 b607d000 r-xp /usr/lib/libXi.so.6.1.0
b6085000 b6088000 r-xp /usr/lib/libXfixes.so.3.1.0
b6090000 b6092000 r-xp /usr/lib/libXgesture.so.7.0.0
b609a000 b609c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b60a5000 b60a7000 r-xp /usr/lib/libXdamage.so.1.1.0
b60af000 b60b6000 r-xp /usr/lib/libXcursor.so.1.0.2
b60be000 b60c1000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60c9000 b60cd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60d6000 b60db000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60e5000 b61c6000 r-xp /usr/lib/libX11.so.6.3.0
b61d1000 b61f4000 r-xp /usr/lib/libjpeg.so.8.0.2
b620c000 b6222000 r-xp /lib/libz.so.1.2.5
b622a000 b629f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b62a9000 b62bf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b62c8000 b62fc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6305000 b63d8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b63e3000 b63f3000 r-xp /lib/libresolv-2.13.so
b63f7000 b6473000 r-xp /usr/lib/libgcrypt.so.20.0.3
b647f000 b6497000 r-xp /usr/lib/liblzma.so.5.0.3
b64a0000 b64a3000 r-xp /lib/libcap.so.2.21
b64ab000 b64d8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b64e0000 b64e1000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b64e9000 b64ef000 r-xp /usr/lib/libecore_imf.so.1.7.99
b64f7000 b650e000 r-xp /usr/lib/liblua-5.1.so
b6518000 b651f000 r-xp /usr/lib/libembryo.so.1.7.99
b6527000 b652d000 r-xp /lib/librt-2.13.so
b6536000 b658c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6599000 b65ef000 r-xp /usr/lib/libfreetype.so.6.11.3
b65fb000 b6623000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6625000 b6662000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b666b000 b667e000 r-xp /usr/lib/libfribidi.so.0.3.1
b6686000 b66a0000 r-xp /usr/lib/libecore_con.so.1.7.99
b66a9000 b66b2000 r-xp /usr/lib/libedbus.so.1.7.99
b66ba000 b670a000 r-xp /usr/lib/libecore_x.so.1.7.99
b670d000 b6711000 r-xp /usr/lib/libvconf.so.0.2.45
b6719000 b672a000 r-xp /usr/lib/libecore_input.so.1.7.99
b6732000 b6737000 r-xp /usr/lib/libecore_file.so.1.7.99
b673f000 b6761000 r-xp /usr/lib/libecore_evas.so.1.7.99
b676a000 b67ab000 r-xp /usr/lib/libeina.so.1.7.99
b67b4000 b67cd000 r-xp /usr/lib/libeet.so.1.7.99
b67de000 b6847000 r-xp /lib/libm-2.13.so
b6850000 b6856000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b685f000 b6862000 r-xp /usr/lib/libproc-stat.so.0.2.86
b686a000 b688c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6894000 b6899000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68a1000 b68cb000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68d4000 b68eb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b68f3000 b68fe000 r-xp /lib/libunwind.so.8.0.1
b692b000 b6967000 r-xp /usr/lib/libsystemd.so.0.4.0
b6970000 b6a8b000 r-xp /lib/libc-2.13.so
b6a99000 b6aa1000 r-xp /lib/libgcc_s-4.6.so.1
b6aa2000 b6aa5000 r-xp /usr/lib/libsmack.so.1.0.0
b6aad000 b6ab3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6abb000 b6b8b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6b8c000 b6be9000 r-xp /usr/lib/libedje.so.1.7.99
b6bf3000 b6c0a000 r-xp /usr/lib/libecore.so.1.7.99
b6c21000 b6cef000 r-xp /usr/lib/libevas.so.1.7.99
b6d14000 b6e4f000 r-xp /usr/lib/libelementary.so.1.7.99
b6e65000 b6e79000 r-xp /lib/libpthread-2.13.so
b6e84000 b6e86000 r-xp /usr/lib/libdlog.so.0.0.0
b6e8e000 b6e91000 r-xp /usr/lib/libbundle.so.0.1.22
b6e99000 b6e9b000 r-xp /lib/libdl-2.13.so
b6ea4000 b6eb0000 r-xp /usr/lib/libaul.so.0.1.0
b6ec2000 b6ec7000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed0000 b6ed4000 r-xp /usr/lib/libsys-assert.so
b6edd000 b6efa000 r-xp /lib/ld-2.13.so
b6f03000 b6f08000 r-xp /usr/bin/launchpad-loader
b8a8c000 b8c46000 rw-p [heap]
be937000 be958000 rwxp [stack]
be937000 be958000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10980)
Call Stack Count: 6
 0: (0xb6ee69dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6ee70d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6ee7360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6eeb5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6ef1a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb69dd70c) [/lib/libc.so.6] + 0x6d70c
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
_MessagePortService::CheckRemotePort
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.windicator:music-control-service-message-port]
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.windicator:music-control-service-message-port]
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:32.052-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1592]   [MUSIC_PLAYER_EVENT][0m
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.windicator:music-control-service-message-port]
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.windicator:music-control-service-message-port]
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:32.052-0500 I/TIZEN_N_SOUND_MANAGER( 1592): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-12 11:42:32.052-0500 W/TIZEN_N_SOUND_MANAGER( 1592): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.windicator:music-control-service-message-port]
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.windicator:music-control-service-message-port]
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:42:32.052-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:32.062-0500 I/APP_CORE( 1114): appcore-efl.c: __do_app(429) > [APP 1114] Event: RESUME State: PAUSED
06-12 11:42:32.062-0500 I/CAPI_APPFW_APPLICATION( 1114): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-12 11:42:32.062-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _music_service_messageport_cb(112) > [_music_service_messageport_cb:112] msg_id:music-mediachanged-ind remote app id:com.samsung.w-music-player.music-control-service
06-12 11:42:32.062-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _music_service_messageport_cb(119) > [_music_service_messageport_cb:119] mode:local state:paused 
06-12 11:42:32.062-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _music_service_messageport_cb(112) > [_music_service_messageport_cb:112] msg_id:music-playstatechanged-ind remote app id:com.samsung.w-music-player.music-control-service
06-12 11:42:32.062-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _music_service_messageport_cb(119) > [_music_service_messageport_cb:119] mode:local state:paused 
06-12 11:42:32.062-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _music_service_messageport_cb(112) > [_music_service_messageport_cb:112] msg_id:music-volumechanged-ind remote app id:com.samsung.w-music-player.music-control-service
06-12 11:42:32.992-0500 I/CAPI_WATCH_APPLICATION(10980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 11:42:33.622-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:1
06-12 11:42:33.622-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:42:33.632-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1091) > [_ecore_event_client_message_cb:1091] quickpanel 1
06-12 11:42:33.822-0500 E/EFL     (  605): <605> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
06-12 11:42:33.992-0500 I/CAPI_WATCH_APPLICATION(10980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-12 11:42:34.032-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(1113) > [_ecore_event_client_message_cb:1113] quickpanel 0
06-12 11:42:34.032-0500 E/W_INDICATOR( 1114): windicator_util.c: _ecore_event_client_message_cb(960) > [_ecore_event_client_message_cb:960] quickpanel is closed
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:34.032-0500 W/W_INDICATOR( 1114): windicator_message_port.c: _mp_messageport_register(324) > [_mp_messageport_register:324] Used message-port
06-12 11:42:34.032-0500 I/MESSAGE_PORT( 1114): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.windicator:music-control-service-message-port], client = 1114
06-12 11:42:34.032-0500 I/MESSAGE_PORT(  880): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-12 11:42:34.032-0500 E/W_INDICATOR( 1114): windicator_moment_bar.c: windicator_moment_bar_hide(1531) > [windicator_moment_bar_hide:1531] Hide Moment Bar : dynamic_layout(0xb13459b0)
06-12 11:42:34.032-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb132d4e0, elm_layout, _activated_obj : 0x0, activated : 0
06-12 11:42:34.032-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-12 11:42:34.032-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb132d4e0, elm_layout, func : 0xb6eeb729
06-12 11:42:34.032-0500 I/efl-extension( 1114): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-12 11:42:34.042-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
06-12 11:42:34.042-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:42:34.052-0500 W/PROCESSMGR(  605): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
06-12 11:42:34.052-0500 W/WATCH_CORE(10980): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
06-12 11:42:34.052-0500 I/WATCH_CORE(10980): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
06-12 11:42:34.052-0500 W/W_HOME  ( 1166): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
06-12 11:42:34.052-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:42:34.052-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:42:34.052-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:42:34.052-0500 W/W_HOME  ( 1166): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
06-12 11:42:34.062-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-12 11:42:34.112-0500 E/CAPI_APPFW_APP_CONTROL( 1592): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-12 11:42:34.112-0500 W/MUSIC_CONTROL_SERVICE( 1592): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1592]   [com.samsung.windicator]register msg port [false][0m
06-12 11:42:34.122-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:42:34.132-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-12 11:42:34.132-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 14
06-12 11:42:34.132-0500 W/AUL_AMD (  926): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1166
06-12 11:42:34.132-0500 I/APP_CORE( 1114): appcore-efl.c: __do_app(429) > [APP 1114] Event: PAUSE State: RUNNING
06-12 11:42:34.132-0500 I/CAPI_APPFW_APPLICATION( 1114): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-12 11:42:34.192-0500 E/PKGMGR  (11260): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-12 11:42:34.332-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: main(2131) > package manager server start
06-12 11:42:34.432-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: req_cb(650) > req_id=[org.example.decimalwatch_1970140680], req_type=[1], pkg_type=[rpm], pkgid=[org.example.decimalwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.decimalwatch_1970140680' '-r' 'org.example.decimalwatch'], cookie=[9CEM5B+kXvwpYtpMlWYBd8Q3LkI=], backend_flag=[0]
06-12 11:42:34.432-0500 E/PKGMGR  (11263): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.decimalwatch]
06-12 11:42:34.432-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.decimalwatch 
06-12 11:42:34.432-0500 E/PKGMGR  (11260): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[112600002]
06-12 11:42:34.432-0500 E/PKGMGR_SERVER(11266): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.decimalwatch]
06-12 11:42:34.602-0500 I/GESTURE (  260): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-12 11:42:34.632-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0xae1b7650 -> 360 0 0xaea29388
06-12 11:42:34.642-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 11:42:34.652-0500 W/W_HOME  ( 1166): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
06-12 11:42:34.652-0500 W/W_HOME  ( 1166): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-12 11:42:34.652-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.652-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.652-0500 W/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-12 11:42:34.692-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, STARTED]
06-12 11:42:34.702-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.decimalwatch is being updateded:0
06-12 11:42:34.702-0500 W/AUL_AMD (  926): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-12 11:42:34.702-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 11:42:34.702-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.702-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.712-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:42:34.722-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.722-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.742-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.742-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.752-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.752-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.762-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.762-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.792-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.792-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.822-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.822-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.832-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.832-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.852-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:34.852-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:34.852-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 11:42:34.852-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(2)
06-12 11:42:34.862-0500 W/WATCH_CORE(10980): appcore-watch.c: __widget_pause(1001) > widget_pause
06-12 11:42:34.962-0500 W/CERT_SVC(11266): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
06-12 11:42:34.972-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 11:42:35.012-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-12 11:42:35.022-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:42:35.032-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 131
06-12 11:42:35.032-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 131
06-12 11:42:35.032-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 54 1
06-12 11:42:35.032-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 55 1
06-12 11:42:35.032-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 56 1
06-12 11:42:35.032-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 57 1
06-12 11:42:35.052-0500 E/PKGMGR_CERT(11266): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-12 11:42:35.262-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 11219
06-12 11:42:35.352-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 11:42:35.392-0500 I/AUL_AMD (  926): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 10960
06-12 11:42:35.592-0500 I/efl-extension(11267): efl_extension.c: eext_mod_init(40) > Init
06-12 11:42:35.622-0500 E/EFL     (11267): elementary<11267> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 11:42:35.622-0500 E/EFL     (11267): elementary<11267> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 11:42:35.652-0500 E/EFL     (11267): elementary<11267> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 11:42:35.652-0500 I/UXT     (11267): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
06-12 11:42:35.652-0500 E/EFL     (11267): elementary<11267> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 11:42:35.682-0500 E/EFL     (11267): elementary<11267> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 11:42:35.682-0500 E/EFL     (11267): elementary<11267> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 11:42:35.692-0500 E/EFL     (11267): elementary<11267> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 11:42:35.692-0500 E/EFL     (11267): elementary<11267> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 11:42:35.692-0500 E/EFL     (11267): elementary<11267> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 11:42:35.732-0500 E/EFL     (11267): elementary<11267> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 11:42:35.742-0500 E/EFL     (11267): elementary<11267> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 11:42:35.742-0500 E/EFL     (11267): elementary<11267> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 11:42:35.782-0500 E/EFL     (11267): elementary<11267> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 11:42:35.782-0500 I/AUL_PAD (11267): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): OpenGL ES Shader Compiler Version: E031.24.00.16
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): Build Date: 09/02/15 Wed
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): Local Branch: 
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): Remote Branch: 
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): Local Patches: 
06-12 11:42:35.812-0500 I/Adreno-EGL(11267): Reconstruct Branch: 
06-12 11:42:36.032-0500 I/RESOURCED(  928): vmpressure-lowmem-handler.c: change_lowmem_state(1098) > [change_lowmem_state,1098] [LOW MEM STATE] mem low ==> mem swap
06-12 11:42:36.032-0500 I/RESOURCED(  928): vmpressure-lowmem-handler.c: adjust_dynamic_threshold(322) > [adjust_dynamic_threshold,322] dynamic_threshold is changed from 50 to 50, cur_mem_state = mem swap, victim_memcg = 5
06-12 11:42:36.372-0500 E/EFL     (11269): elementary<11269> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-12 11:42:36.372-0500 E/EFL     (11269): elementary<11269> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-12 11:42:36.432-0500 E/EFL     (11269): elementary<11269> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-12 11:42:36.432-0500 E/EFL     (11269): elementary<11269> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-12 11:42:36.462-0500 E/EFL     (11269): elementary<11269> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-12 11:42:36.462-0500 E/EFL     (11269): elementary<11269> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-12 11:42:36.462-0500 E/EFL     (11269): elementary<11269> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-12 11:42:36.462-0500 E/EFL     (11269): elementary<11269> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-12 11:42:36.462-0500 E/EFL     (11269): elementary<11269> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-12 11:42:36.532-0500 E/EFL     (11269): elementary<11269> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-12 11:42:36.532-0500 E/EFL     (11269): elementary<11269> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-12 11:42:36.532-0500 E/EFL     (11269): elementary<11269> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-12 11:42:36.642-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:42:36.792-0500 E/EFL     (11269): elementary<11269> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-12 11:42:36.842-0500 E/EFL     (11269): elementary<11269> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-12 11:42:36.842-0500 E/EFL     (11269): elementary<11269> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-12 11:42:36.842-0500 E/EFL     (11269): elementary<11269> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-12 11:42:36.842-0500 E/EFL     (11269): elementary<11269> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-12 11:42:36.842-0500 E/EFL     (11269): elementary<11269> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-12 11:42:36.842-0500 E/EFL     (11269): elementary<11269> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-12 11:42:36.842-0500 I/AUL_PAD (11269): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-12 11:42:37.222-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0xaea29388 -> 360 0 0xaeaaaa60
06-12 11:42:37.222-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 11:42:37.242-0500 E/EFL     ( 1272): evas_main<1272> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
06-12 11:42:37.242-0500 E/EFL     ( 1272): evas_main<1272> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
06-12 11:42:37.242-0500 E/EFL     ( 1272): evas_main<1272> evas_object_main.c:1368 evas_object_color_set() Evas only handles pre multiplied colors!
06-12 11:42:37.252-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.252-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.262-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.262-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.282-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 11:42:37.282-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.282-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.302-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.302-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.322-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.322-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.342-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.342-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.362-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.362-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.372-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.372-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.392-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.392-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.402-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:37.402-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:37.412-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 11:42:37.412-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(3)
06-12 11:42:37.522-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
06-12 11:42:37.522-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-12 11:42:37.542-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 11:42:37.842-0500 E/rpm-installer(11266): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
06-12 11:42:37.912-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 11:42:38.642-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:42:38.772-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0xaeaaaa60 -> 360 0 0xaeaf6bd8
06-12 11:42:38.772-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 11:42:38.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:38.832-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 11:42:38.832-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.832-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:38.862-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.862-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:38.872-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.872-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:38.912-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.912-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:38.942-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.942-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:38.982-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:38.982-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:39.022-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:39.022-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:39.032-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:39.032-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:39.082-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:39.082-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:39.082-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 11:42:39.082-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(2)
06-12 11:42:39.142-0500 I/APP_CORE( 1114): appcore-efl.c: __do_app(429) > [APP 1114] Event: MEM_FLUSH State: PAUSED
06-12 11:42:39.142-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __provider_pause_cb(296) > widget obj was paused
06-12 11:42:39.142-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __check_status_for_cgroup(145) > enter background group
06-12 11:42:39.212-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 11:42:39.582-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 11:42:40.642-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-12 11:42:40.772-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0xaea29388 -> 360 0 0xaeaaaa60
06-12 11:42:40.772-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 11:42:40.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.782-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.802-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.802-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.812-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.812-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.822-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.822-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.832-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-12 11:42:40.842-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.842-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.862-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.862-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.872-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.872-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.892-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.892-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.912-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.912-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.922-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.922-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.942-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.942-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.952-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.952-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.972-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.972-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:40.992-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:40.992-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.002-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.002-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.022-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.022-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.032-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 11:42:41.032-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(3)
06-12 11:42:41.142-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
06-12 11:42:41.142-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-12 11:42:41.172-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 11:42:41.562-0500 W/W_HOME  ( 1166): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0xaeaaaa60 -> 360 0 0xaeaf6bd8
06-12 11:42:41.562-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,start
06-12 11:42:41.582-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.582-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.612-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.612-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.632-0500 W/W_HOME  ( 1166): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-12 11:42:41.632-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.632-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.672-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.672-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.712-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.712-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.732-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-12 11:42:41.732-0500 I/ELM_RPANEL( 1166): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-12 11:42:41.742-0500 W/wnotib  ( 1166): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-12 11:42:41.742-0500 I/efl-extension( 1166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb85f6688 : elm_scroller] CurrentPage(4)
06-12 11:42:41.862-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __provider_pause_cb(296) > widget obj was paused
06-12 11:42:41.862-0500 I/CAPI_WIDGET_APPLICATION( 1273): widget_app.c: __check_status_for_cgroup(145) > enter background group
06-12 11:42:41.872-0500 I/CAPI_WIDGET_APPLICATION( 1274): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
06-12 11:42:41.872-0500 I/CAPI_WIDGET_APPLICATION( 1274): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-12 11:42:41.882-0500 W/W_HOME  ( 1166): event_manager.c: _home_scroll_cb(564) > scroll,done
06-12 11:42:42.182-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, PROCESSING]
06-12 11:42:42.192-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: sighandler(409) > child NORMAL exit [11266]
06-12 11:42:42.192-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.decimalwatch is updated, need to check validation
06-12 11:42:42.192-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.example.decimalwatch
06-12 11:42:42.222-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_log_package(4525) > package [_________] callback : [UPDATE, COMPLETED]
06-12 11:42:42.222-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6915) > package install complete
06-12 11:42:42.222-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_package_install_event(4787) > 
06-12 11:42:42.222-0500 E/WMS     (  894): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
06-12 11:42:42.332-0500 E/STARTER ( 1103): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
06-12 11:42:42.332-0500 W/W_HOME  ( 1166): clock_event.c: _pkgmgr_event_cb(249) > clock org.example.decimalwatch is updated, preload:0 update:0 event->update:0
06-12 11:42:42.352-0500 E/APPS    ( 1166): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
06-12 11:42:42.362-0500 E/PKGMGR_INFO(  891): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-12 11:42:42.442-0500 W/W_HOME  ( 1166): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-12 11:42:42.552-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 4
06-12 11:42:42.552-0500 E/AUL_AMD (  926): amd_request.c: __app_process_by_pid(193) > pid(10980) is dead. cmd(4) is canceled
06-12 11:42:42.552-0500 W/AUL_AMD (  926): amd_request.c: __request_handler(646) > __request_handler: 0
06-12 11:42:42.562-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 11:42:42.572-0500 I/AUL_AMD (  926): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
06-12 11:42:42.572-0500 E/AUL_AMD (  926): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
06-12 11:42:42.572-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(1708) > caller pid : 1122
06-12 11:42:42.642-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-12 11:42:42.642-0500 E/PKGMGR_SERVER(11263): pkgmgr-server.c: main(2185) > package manager server terminated.
06-12 11:42:42.682-0500 E/RESOURCED(  928): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.decimalwatch, table num : 7
06-12 11:42:42.682-0500 E/RESOURCED(  928): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-12 11:42:42.712-0500 W/AUL_AMD (  926): amd_launch.c: _start_app(2086) > pad pid(-5)
06-12 11:42:42.712-0500 W/AUL_PAD ( 1664): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
06-12 11:42:42.712-0500 W/AUL_PAD ( 1664): launchpad.c: __send_result_to_caller(272) > Check app launching
06-12 11:42:42.742-0500 I/CAPI_WATCH_APPLICATION(11269): watch_app_main.c: watch_app_main(382) > watch_app_main
06-12 11:42:42.762-0500 W/CRASH_MANAGER(11276): worker.c: worker_job(1199) > 1110980646563146574976
