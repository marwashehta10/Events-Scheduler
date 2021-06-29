#pragma once
#include<iostream>
#include<string>
#include<map>
#include<fstream>
using namespace std;
struct key
{
	string place, startdate,enddate;
	bool operator<(const key &a)const
	{
		return(a.startdate > startdate || (a.startdate == startdate && a.enddate > enddate) || (a.enddate == enddate && a.place > place));

	}

};
class event
{
public:
	string name, startdate,place,enddate;
	bool done;
	event();
	~event();
};
class user
{
public:
	int id;
	string username, password;
	map<key, event> user0;
	map<key, event> user1;
	map<key, event> user2;
	map<int, user> info;
	map<key, event>::iterator it;
	map<key,event>Edone1;
	map<key,event>Edone2;
	map<key,event>Edone3;
	user();
	void getinfo();
	int login();
	void choese(map<key, event> tmp, map<key, event> ptr);
	void add(map<key, event> tmp,map<key, event> ptr);
	void display(map<key, event> tmp,map<key, event> ptr);
	void remove(map<key, event> tmp, map<key, event> ptr );
	void update(map<key, event> tmp,map<key, event> ptr);
	void displaydoneevent(map<key, event> tmp,map<key, event> ptr);
	void letinfo();
};

