echo "Hello"

rm -rf /output
mkdir output

echo "Building x86 libs"
xcodebuild -project MBProgressHUD.xcodeproj -target MBProgressHUD -sdk iphonesimulator -configuration Release clean build
cp build/Release-iphonesimulator/libMBProgressHUD.a output/MBProgressHUD-i386.a

echo "Building arm64 libs"
xcodebuild -project MBProgressHUD.xcodeproj -target MBProgressHUD -sdk iphoneos -arch arm64 -configuration Release clean build
cp build/Release-iphoneos/libMBProgressHUD.a output/MBProgressHUD-arm64.a

echo "Building armv7 libs"
xcodebuild -project MBProgressHUD.xcodeproj -target MBProgressHUD -sdk iphoneos -arch armv7 -configuration Release clean build
cp build/Release-iphoneos/libMBProgressHUD.a output/MBProgressHUD-armv7.a

echo "Building armv7s libs"
xcodebuild -project MBProgressHUD.xcodeproj -target MBProgressHUD -sdk iphoneos -arch armv7s -configuration Release clean build
cp build/Release-iphoneos/libMBProgressHUD.a output/MBProgressHUD-armv7s.a

echo "Building universal libs"
lipo -create -output output/MBProgressHUD-universal.a output/MBProgressHUD-i386.a output/MBProgressHUD-arm64.a output/MBProgressHUD-armv7.a output/MBProgressHUD-armv7s.a