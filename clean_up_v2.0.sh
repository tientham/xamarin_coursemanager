#!/bin/sh
# Author: Minh Tien TO (tien.tominh@gmail.com)
# Ver: 1.0.2 - clean up xamarin env and nodejs, angular env

echo "Cleaning up Nodejs - Angular environments"
echo "It will clean node_modules/ folder"

echo "Cleaning node_modules/ ......."
for i in $( find . -name "node_modules" ); do
	echo deleting.... $i
	rm -r $i
done

echo "Cleaning up Xamarin environment"
echo "It will clean obj/ and bin/ folder"

echo "Cleaning obj/ ......"

for i in $( find . -name "obj" ); do
	echo deleting.... $i
	rm -r $i
done

echo "Cleaning bin/ ......."
for i in $( find . -name "bin" ); do
	echo deleting.... $i
	rm -r $i
done

echo "Done"
