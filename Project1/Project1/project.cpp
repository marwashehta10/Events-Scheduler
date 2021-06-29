#include "project.h"
event::event()
{
	name = ' ';
	startdate = ' '; 
	done = true;
}
event::~event()
{
}
user::user()
{
	username = ' ';
	password = ' ';
}
void user::getinfo()
{
	key k;
	event s;
	ifstream in1, in2, in3, in4,in5,in6,in7;
	in1.open("user0.txt");
	while (in1 >> s.name >> s.startdate >> s.place >> s.enddate)
	{
		k.startdate = s.startdate;
		k.enddate = s.enddate;
		k.place = s.place;
		user0.insert({ k, s });

	}
	in1.close();
	in2.open("user1.txt");
	while (in2 >> s.name >> s.startdate >> s.place >> s.enddate)
	{
		k.startdate = s.startdate;
		k.enddate = s.enddate;
		k.place = s.place;
		user1.insert({ k, s });
	}
	in2.close();
	in3.open("user2.txt");
	while (in3 >> s.name >> s.startdate >> s.place >> s.enddate)
	{
		k.startdate = s.startdate;
		k.enddate = s.enddate;
		k.place = s.place;
		user2.insert({ k, s });
	}
	in3.close();
	in4.open("users.txt");
	user q;
	while (in4 >> q.username >> q.password >> id)
	{
		info.insert({id,q});
	}
	in4.close();
	in5.open("eventdone1.txt");
	while (in5 >> s.name >> s.startdate >> s.place >> s.enddate)
	{
		k.startdate = s.startdate;
		k.enddate = s.enddate;
		k.place = s.place;
		Edone1.insert({ k, s });
	}
	in5.close();
	in6.open("eventdone2.txt");
	while (in6 >> s.name >> s.startdate >> s.place >> s.enddate)
	{
		k.startdate = s.startdate;
		k.enddate = s.enddate;
		k.place = s.place;
		Edone2.insert({ k, s });
	}
	in6.close();
	in7.open("eventdone3.txt");
	while (in7 >> s.name >> s.startdate >> s.place >> s.enddate)
	{
		k.startdate = s.startdate;
		k.enddate = s.enddate;
		k.place = s.place;
		Edone1.insert({ k, s });
	}
	in7.close();
}
int user::login()
{
	while (true){
		string uname, pass;
		int id = -1;
		cout << "please enter your username :";
		cin >> uname;
		cout << "please enter your password : ";
		cin >> pass;
		for (int i = 0; i < 3; i++)
		{
			if (info[i + 1].username == uname && info[i + 1].password == pass)
				id = i + 1;
		}

		if (id == -1)
		{
			cout << "EROR Please enter correct username and password" << endl;
			continue;
		}
		else
			return id;
	}

}
void user::choese(map<key, event> tmp, map<key, event> ptr)
{
	key k;
	int chose;
		cout << "please press 1 to add Event " << endl;
		cout << "please press 2 to delete Event " << endl;
		cout << "please press 3 to update Event " << endl;
		cout << "please press 4 to display your Event " << endl;
		cout << "please press 5 to display your done Event " << endl;
		cout << "please press 6 to exist " << endl;
		cin >> chose;
		switch (chose)
		{
		case 1:
			add(tmp,ptr);
		case 2:
			remove(tmp,ptr);
		case 3:
			update(tmp,ptr);
		case 4:
			display(tmp,ptr);
		case 5:
			displaydoneevent(tmp,ptr);
		case 6:
			letinfo();
		default:
			break;
		}
}
void user::add(map<key, event> tmp, map<key, event> ptr)
{
	key k;
	event s;
		cout << "please enter username :";
		cin >> s.name;
		cout << "please enter startdate :";
		cin >> s.startdate;
		k.startdate = s.startdate;
		cout << "please enter place :";
		cin >> s.place;
		k.place = s.place;
		cout << "please enter enddate :";
		cin >> s.enddate;
		k.enddate = s.enddate;
		if (tmp.find(k) != tmp.end())
		{
			cout << "You have event in this time and place";

		}
		else
		{
			tmp.insert({ k, s });
			cout << "Done" << endl;
		}
		choese(tmp,ptr);
}
void user::display(map<key, event> tmp, map<key, event> ptr)
{
	for (it = tmp.begin(); it != tmp.end(); it++)
	{

		cout << it->second.name << endl << it->second.startdate << endl << it->second.enddate << endl << it->second.place << endl;

	}
	choese(tmp, ptr);

}
void user::remove(map<key, event> tmp, map<key, event> ptr)
{
	key k;
	cout << "please Enter place,startdate and endtime for event you want delete it";
	cin >> k.place >> k.startdate>>k.enddate;
	if (tmp.find(k) != tmp.end())
	{
		ptr.insert({ k, tmp[k] });
		tmp.erase(k);
		cout << "Done" << endl;
	}
	else
	{
		cout << "you not have event have this place and endedtime";
	}
	choese(tmp,ptr);
}
void user::update(map<key, event> tmp, map<key, event> ptr)
{
	key k;
	event s;
	int choice;
	cout << "please Enter place,startdate and endtime for event you want update it";
	cout << "please enter place :";
	 cin>>k.place;
	 cout << "please enter startdate";
	 cin >> k.startdate;
	cout << "please enter enddate :";
	  cin>>k.enddate ;
	  if (tmp.find(k) != tmp.end())
	  {
		  tmp.erase(k);
		  add(tmp,ptr);
	  }
	else
	{
		cout << "you not have event have this place and endedtime";
	}

	choese(tmp,ptr);

}
void user::displaydoneevent(map<key, event> tmp, map<key, event> ptr)
{
	for (it = ptr.begin(); it != ptr.end(); it++)
	{

		cout << it->second.name << endl << it->second.startdate << endl << it->second.enddate << endl << it->second.place << endl;

	}
	choese(tmp, ptr);



}
void user::letinfo()
{
	ofstream in1, in2, in3, in4, in5, in6, in7;
	in1.open("user0.txt");
	for (it = user0.begin(); it != user0.end();it++)
	{
		in1 << it->second.name << '  ' << it->second.startdate << '  ' << it->second.place << '  ' << it->second.enddate<<endl;

	}
	in1.close();
	in2.open("user1.txt");
	for (it = user1.begin(); it != user1.end(); it++)
	{
		in2 << it->second.name << '  ' << it->second.startdate << '  ' << it->second.place << '  ' << it->second.enddate<<endl;

	}
	in2.close();
	in3.open("user2.txt");
	for (it = user2.begin(); it != user2.end(); it++)
	{
		in3 << it->second.name << '  ' << it->second.startdate << '  ' << it->second.place << '  ' << it->second.enddate<<endl;

	}
	in3.close();
	in5.open("eventdone1.txt");
	for (it = Edone1.begin(); it != Edone1.end(); it++)
	{
		in5 << it->second.name << '  ' << it->second.startdate << '  ' << it->second.place << '  ' << it->second.enddate<<endl;

	}
	in5.close();
	in6.open("eventdone2.txt");
	for (it = Edone2.begin(); it != Edone2.end(); it++)
	{
		in6 << it->second.name << '  ' << it->second.startdate << '  ' << it->second.place << '  ' << it->second.enddate<<endl;

	}
	in6.close();
	in7.open("eventdone3.txt");
	for (it = Edone3.begin(); it != Edone3.end(); it++)
	{
		in7 << it->second.name << '  ' << it->second.startdate << '  ' << it->second.place << '  ' << it->second.enddate<<endl;

	}
	in7.close();

}