Feature: OrderCheckoutFeature

Background: 
	Given Create products as follow
	| Index | Name    | Price |
	| 0     | Starter | 4     |
	| 1     | Main    | 7     |
	| 2     | Drink   | 2.5   |

Scenario: ThreeProductsBy4Items_Checkout_BillIsCorrect
	When Create order
	And Add items to order as follow
	| ProductIndex | Count |
	| 0            | 4     |
	| 1            | 4     |
	| 2            | 4     |
	And Checkout order
	Then Bill is as follow
	| Amount | Discount | AmountDiscounted | Service | Total |
	| 54     | 0        | 54               | 5.4     | 59.4  |

Scenario: SeveralItemsWithDiscountSeveralTooLate_Checkout_BillIsCorrect
	And Set discount by time as follow
	| ProductIndex | StartTime        | EndTime          | DiscountValue |
	| 2            | Now - 10 minutes | Now + 5 seconds | 0.3           |
	When Create order
	And Add items to order as follow
	| ProductIndex | Count |
	| 0            | 1     |
	| 1            | 2     |
	| 2            | 2     |
	And Wait '6' seconds after discount creation
	And Add items to order as follow
	| ProductIndex | Count |
	| 1            | 2     |
	| 2            | 2     |
	And Checkout order
	Then Bill is as follow
	| Amount | Discount | AmountDiscounted | Service | Total |
	| 42     | 1.5      | 40.5             | 4.05    | 44.55 |

Scenario: ThreeProductsBy4Items_CancellAllProductsBy1QtyAndCheckout_BillIsCorrect
	When Create order
	And Add items to order as follow
	| ProductIndex | Count |
	| 0            | 4     |
	| 1            | 4     |
	| 2            | 4     |
	And Cancel items as follow
	| ProductIndex | Count |
	| 0            | 1     |
	| 1            | 1     |
	| 2            | 1     |
	And Checkout order
	Then Bill is as follow
	| Amount | Discount | AmountDiscounted | Service | Total |
	| 40.5   | 0        | 40.5             | 4.05    | 44.55 |