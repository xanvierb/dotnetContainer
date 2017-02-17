#!/bin/bash
sleeping=20
for i in {1..20}
do
  let sleepleft=$sleeping-$i+1
  echo "Still sleeping for $sleepleft seconds ZZzz.."
  sleep 1
done
echo "Start EF Migration"
dotnet ef migrations add init5
echo "Start database update"
dotnet ef database update
echo "Start project running"
dotnet out/ContactsApi.dll