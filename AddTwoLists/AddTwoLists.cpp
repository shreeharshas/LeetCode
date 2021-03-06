#include "stdafx.h"
#include <iostream>
using namespace std;
/**
* Definition for singly-linked list.
*/
struct ListNode {
	int val;
	ListNode *next;
	ListNode(int x) : val(x), next(NULL) {}
};
ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
	short carry = 0;
	ListNode *p1 = l1, *p2 = l2, *a = NULL, *prev = NULL, *ans = NULL;
	int sum = 0;
	while (true) {
		if (p1 == NULL && p2 == NULL) {
			break;
		}
		if (p1 != NULL && p2 == NULL) {
			sum = p1->val + carry;
			p1 = p1->next;
		}
		else if (p1 == NULL && p2 != NULL) {
			sum = p2->val + carry;
			p2 = p2->next;
		}
		else if (p1 != NULL && p2 != NULL) {
			sum = p1->val + p2->val + carry;
			p1 = p1->next;
			p2 = p2->next;
		}

		if (sum>9) {
			carry = 1;
			sum %= 10;
		}
		else
			carry = 0;

		a = new ListNode(sum);
		if (ans == NULL)
			ans = a;
		else
			prev->next = a;
		prev = a;
	}
	if (carry == 1)
		a->next = new ListNode(1);
	return ans;
}


	void printList(char * name, ListNode *node)
	{
		cout <<name<<":";
		while (node != NULL)
		{
			cout<<node->val<<"->";
			node = node->next;
		}
		cout << endl;
	}

	int main(void)
	{

		ListNode* res = NULL, * first = NULL, *second = NULL;
		
		first = new ListNode(2);
		ListNode *m11 = new ListNode(3);
		first->next = m11;
		ListNode *m12 = new ListNode(4);
		m11->next = m12;
		printList("first",first);

		second = new ListNode(6);
		ListNode *m21 = new ListNode(7);
		second->next = m21;
		ListNode *m22 = new ListNode(8);
		m21->next = m22;
		printList("second", second);

		res = addTwoNumbers(first, second);
		printList("result", res);
		char y;
		cin >> y;
		return 0;

	}

