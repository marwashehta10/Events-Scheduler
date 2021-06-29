#include"project.h"
using namespace std;
void main()
{
	cout << "Welcome" << endl;
	user x;
	int _id;
	x.getinfo();
	_id=x.login();
	 if(_id == 1)
	{
		cout << "Welcome   " << x.info[1].username<<endl;
		x.choese(x.user0,x.Edone1);
	}
	else if (_id == 2)
	{
		cout << "Welcome   " << x.info[2].username;
		x.choese(x.user1,x.Edone2);
	}
	else if (_id == 3)
	{
		cout << "Welcome   " << x.info[3].username;
		x.choese(x.user2,x.Edone3);
	}
	system("pause");
}