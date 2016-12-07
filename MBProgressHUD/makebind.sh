echo "Binding stated"
 sharpie bind \
 	-o Binding \
 	-sdk iphoneos10.1 \
    -scope . \
    	MBProgressHUD/MBProgressHUD.h \
    -c \
        -Ibuild/Release-iphoneos/include -unified